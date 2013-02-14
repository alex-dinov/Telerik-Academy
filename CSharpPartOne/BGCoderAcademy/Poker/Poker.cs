using System;

class Poker
{
    static void Main()
    {
        int[] cards = new int[13];
        int n;
        for (int i = 0; i < 5; i++)
        {
            string card = Console.ReadLine();
            if (card=="A")
            {
                n=12;
            }
            else if (card=="J")
            {
                n = 9;
            }
            else if (card=="Q")
            {
                n = 10;
            }
            else if (card=="K")
            {
                n = 11;
            }
            else
            {
                n = int.Parse(card)-2;
            }
            cards[n]++;
        }
         int pair = 0;
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i]==2)
            {
                pair++;
            }
        }
       
        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < cards.Length; j++)
            {
                if (cards[j] == 5)
                {
                    Console.WriteLine("Impossible");
                    return;
                }
                else if (cards[j] == 4)
                {
                    Console.WriteLine("Four of a Kind");
                    return;
                }
                else if (cards[j] == 3 && cards[i] == 2)
                {
                    Console.WriteLine("Full House");
                    return;
                }
                else if (j<9 && cards[j]==1 && cards[j+1]==1 && cards[j+2]==1 && cards[j+3]==1 && cards[j+4]==1)
                {
                    Console.WriteLine("Straight");
                    return;
                }
                else if (cards[0]==1 && cards[1]==1 && cards[2]==1 && cards[3]==1 && cards[12]==1)
                {
                    Console.WriteLine("Straight");
                    return;
                }
                else if (cards[i]==3 && cards[j]==1)
                {
                    Console.WriteLine("Three of a Kind");
                    return;
                }
                else if (pair==2 && cards[i]==2 && cards[j]==2)
                {
                    Console.WriteLine("Two Pairs");
                    return;
                }
                else if (pair == 1 && cards[i] == 1 && cards[j] == 1)
                {
                    Console.WriteLine("One Pair");
                    return;
                }            
            }
        }
        Console.WriteLine("Nothing");
        return;
    }
}

