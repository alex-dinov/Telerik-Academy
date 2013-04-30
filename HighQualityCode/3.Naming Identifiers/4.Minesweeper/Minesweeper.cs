using System;
using System.Collections.Generic;
using System.Linq;

namespace Minesweeper
{
	public class Minesweeper
	{
        static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] field = CreateField();
			char[,] bombs = PlaceMinesField();
			int counter = 0;
			bool boom = false;
            List<Points> winners = new List<Points>(6);
            int row = 0;
			int column = 0;
			bool startGame = true;
			const int MaximalScore = 35;
			bool endGame = false;

			do
			{
                if (startGame)
				{
					Console.WriteLine("Let's play Minesweeper. Try find field without mines!\n" +
					"Command 'top' shows the ranking, 'restart' starts new game, 'exit' exits the game!");
					PrintField(field);
					startGame = false;
				}

				Console.Write("Give row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
				{
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
						row <= field.GetLength(0) && column <= field.GetLength(1))
					{
                        command = "turn";
					}
				}

                switch (command)
				{
					case "top":
                        GetRanking(winners);
						break;
					case "restart":
						field = CreateField();
						bombs = PlaceMinesField();
						PrintField(field);
						boom = false;
						startGame = false;
						break;
					case "exit":
						Console.WriteLine("Bye, Bye, Bye!");
						break;
					case "turn":
                        if (bombs[row, column] != '*')
						{
                            if (bombs[row, column] == '-')
							{
                                MakeMove(field, bombs, row, column);
								counter++;
							}

                            if (MaximalScore == counter)
							{
								endGame = true;
							}
							else
							{
								PrintField(field);
							}
						}
						else
						{
							boom = true;
						}

						break;
					default:
						Console.WriteLine("\nError! Invalid command!\n");
						break;
				}

				if (boom)
				{
                    PrintField(bombs);
					Console.Write("\nBoooooom! You died with {0} points. Your Nickname: ", counter);
					string nickname = Console.ReadLine();
                    Points newUserPoints = new Points(nickname, counter);
					if (winners.Count < 5)
					{
                        winners.Add(newUserPoints);
					}
					else
					{
						for (int i = 0; i < winners.Count; i++)
						{
                            if (winners[i].TotalPoints < newUserPoints.TotalPoints)
							{
                                winners.Insert(i, newUserPoints);
								winners.RemoveAt(winners.Count - 1);
								break;
							}
						}
					}

                    winners.Sort((Points p1, Points p2) => p2.Name.CompareTo(p1.Name));
                    winners.Sort((Points p1, Points p2) => p2.TotalPoints.CompareTo(p1.TotalPoints));
                    GetRanking(winners);

					field = CreateField();
                    bombs = PlaceMinesField();
					counter = 0;
					boom = false;
					startGame = true;
				}

				if (endGame)
				{
					Console.WriteLine("\nCongratulations! You open 35 cells!");
                    PrintField(bombs);
                    Console.WriteLine("Your Nickname: ");
					string name = Console.ReadLine();
                    Points points = new Points(name, counter);
                    winners.Add(points);
                    GetRanking(winners);
					field = CreateField();
					bombs = PlaceMinesField();
					counter = 0;
					endGame = false;
					startGame = true;
				}
			}
			while (command != "exit");
		}

		private static void GetRanking(List<Points> points)
		{
			Console.WriteLine("\nPoints:");
            if (points.Count > 0)
			{
                for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].Name, points[i].TotalPoints);
				}

				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("empty ranking!\n");
			}
		}

		private static void MakeMove(char[,] field, char[,] bombs, int row, int column)
		{
            char countBombs = CountNearbyMines(bombs, row, column);
            bombs[row, column] = countBombs;
            field[row, column] = countBombs;
		}

		private static void PrintField(char[,] board)
		{
			int row = board.GetLength(0);
			int column = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
			{
				Console.Write("{0} | ", i);
                for (int j = 0; j < column; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}

				Console.Write("|");
				Console.WriteLine();
			}

			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateField()
		{
			int boardRows = 5;
			int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
			{
                for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PlaceMinesField()
		{
			int rows = 5;
			int columns = 10;
            char[,] field = new char[rows, columns];

            for (int i = 0; i < rows; i++)
			{
                for (int j = 0; j < columns; j++)
				{
                    field[i, j] = '-';
				}
			}

			List<int> randomMines = new List<int>();
            while (randomMines.Count < 15)
			{
				Random random = new Random();
				int nextMine = random.Next(50);
                if (!randomMines.Contains(nextMine))
				{
                    randomMines.Add(nextMine);
				}
			}

            foreach (int mine in randomMines)
			{
                int column = mine / columns;
                int row = mine % columns;
                if (row == 0 && mine != 0)
				{
                    column--;
                    row = columns;
				}
				else
				{
                    row++;
				}

                field[column, row - 1] = '*';
			}

            return field;
		}

		private static char CountNearbyMines(char[,] field, int row, int column)
		{
			int count = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (row - 1 >= 0)
			{
                if (field[row - 1, column] == '*')
				{ 
					count++; 
				}
			}

            if (row + 1 < rows)
			{
                if (field[row + 1, column] == '*')
				{ 
					count++; 
				}
			}

			if (column - 1 >= 0)
			{
                if (field[row, column - 1] == '*')
				{ 
					count++;
				}
			}

            if (column + 1 < columns)
			{
                if (field[row, column + 1] == '*')
				{ 
					count++;
				}
			}

            if ((row - 1 >= 0) && (column - 1 >= 0))
			{
                if (field[row - 1, column - 1] == '*')
				{ 
					count++; 
				}
			}

            if ((row - 1 >= 0) && (column + 1 < columns))
			{
                if (field[row - 1, column + 1] == '*')
				{ 
					count++; 
				}
			}

            if ((row + 1 < rows) && (column - 1 >= 0))
			{
                if (field[row + 1, column - 1] == '*')
				{ 
					count++; 
				}
			}

            if ((row + 1 < rows) && (column + 1 < columns))
			{
                if (field[row + 1, column + 1] == '*')
				{ 
					count++; 
				}
			}

			return char.Parse(count.ToString());
		}
	}
}
