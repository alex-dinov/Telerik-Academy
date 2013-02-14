using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat2011
{
    class MissCat2011
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int vote;
            int winner;

            List<int> votes = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            for (int i = 1; i <= n; i++)
            {
                vote = int.Parse(Console.ReadLine());
                votes[vote-1]++;
            }
            winner = votes.IndexOf(votes.Max())+1;
            Console.WriteLine(winner);
        }
    }
}
