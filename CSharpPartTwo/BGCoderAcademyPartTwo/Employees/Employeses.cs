using System;
using System.Collections.Generic;
using System.Linq;

class Employeses
{
    static Dictionary<string, int> positions = new Dictionary<string, int>();
    static List<Tuple<string, string, string, int>> names = new List<Tuple<string, string, string, int>>();
    static char[] separators = { '-' };

    static void Main()
    {
        ReadPositions();
        ReadNames();
        var sorted = names.OrderByDescending(x => x.Item4).ThenBy(x => x.Item2).ThenBy(x => x.Item1);
        foreach (var item in sorted)
        {
            Console.WriteLine("{0} {1}",item.Item1,item.Item2);
        }
    }

    static void ReadPositions()
    {
        int position = int.Parse(Console.ReadLine());
        for (int i = 0; i < position; i++)
        {
            string[] line=Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);
            if (!positions.Keys.Contains(line[0].Trim()))
            {
                positions.Add(line[0].Trim(), int.Parse(line[1]));
            }
        }
    }

    static void ReadNames()
    {
        int people = int.Parse(Console.ReadLine());
        for (int i = 0; i < people; i++)
        {
            string[] line = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] name=line[0].Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            string position=line[1].Trim();
            string firstName = name[0].Trim();
            string lastName = name[name.Length - 1].Trim();
            if (positions.ContainsKey(position))
            {
                names.Add(new Tuple<string, string, string, int>(firstName, lastName, position, positions[position]));
            }
        }
    }
}

