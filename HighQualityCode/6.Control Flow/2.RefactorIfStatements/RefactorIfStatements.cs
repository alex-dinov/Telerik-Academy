using System;
using System.Linq;

namespace _2.RefactorIfStatements
{
    public class RefactorIfStatements
    {
        private static void Main(string[] args)
        {
            Potato potato = new Potato();

            if (potato != null && potato.HasBeenPeeled && !potato.IsRotten)
            {
                Cook(potato);
            }

            int x = 0;
            int y = 0;
            const int MinX = -200;
            const int MaxX = 200;
            const int MinY = -200;
            const int MaxY = 200;

            bool shouldVisitCell = true;

            if ((MinX <= x && x <= MaxX) && (MinY <= y && y <= MaxY) && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
