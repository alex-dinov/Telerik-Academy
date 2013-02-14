using System;
using System.Text;

class GenomeDecoder
{
    static void Main()
    {
        string NandM = Console.ReadLine(); 
        string genome = Console.ReadLine();
        char[] separators = { ' ' };
        string[] numbers = NandM.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int N = 0;
        int M = 0;
      
        N=int.Parse(numbers[0]);
        M = int.Parse(numbers[1]);
        
        PrintGenome(DecodeGenome(genome), N, M);
        
    }

    static string DecodeGenome(string genome)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < genome.Length; i++)
        {
            StringBuilder lenght=new StringBuilder();
            while (genome[i]!='A' && genome[i]!='G' && genome[i]!='T' && genome[i]!='C')
            {
                lenght=lenght.Append(genome[i]);
                i++;
            }
            int number = 0;
            if (lenght.ToString() != "")
            {
                number = int.Parse(lenght.ToString());
            }
            if (lenght.ToString()=="")
            {
                number = 1;
            }
            for (int j = 0; j < number; j++)
            {
                sb.Append(genome[i]);
            }
        }
        return sb.ToString();

    }

    static void PrintGenome(string genome, int N, int M)
    {
        int maxRow = 0;
        if (genome.Length%N==0)
        {
            maxRow = genome.Length / N;
        }
        else
        {
            maxRow = genome.Length / N + 1;
        }
        int maxCol=0;
        int whitespaces=0;
        if (N%M==0)
        {
		    whitespaces=N/M;
        }
        else
	    {
            whitespaces=N/M+1;
	    }
        int counter = 0;
        int lineNumber = 1;
        int padLeft = maxRow.ToString().Length;
        maxCol = N + whitespaces + padLeft;
        StringBuilder line = new StringBuilder();
        for (int row = 0; row < maxRow; row++)
        {
            line.Append(lineNumber.ToString().PadLeft(padLeft));
            for (int col = padLeft; col < maxCol-1; col++)
            {
                if (counter == genome.Length)
                {
                    break;
                }
                line.Append(" ");
                for (int i = 0; i < M && col<maxCol-1; i++)
                {
                    if (counter<genome.Length)
                    {
                       line.Append(genome[counter]);
                        col++;
                        counter++;
                    }
                }
                
            }
            lineNumber++;
            if (counter == genome.Length)
            {
                break;
            }
            line.Append("\n");
        }
        Console.WriteLine(line.ToString());
    }
}

