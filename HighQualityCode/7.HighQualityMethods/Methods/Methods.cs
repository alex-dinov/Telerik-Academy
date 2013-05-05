using System;

namespace Methods
{
    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static string ConvertDigitToText(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("Value is not in the range [0-9]!");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Input cannot be null!");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Elements cannot be empty!");
            }

            int max = elements[0];

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static void PrintNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        public static bool IsLineVertical(double x1, double x2)
        {
            bool isVertical = x1 == x2;
            return isVertical;
        }

        public static bool IsLineHorizontal(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;
            return isHorizontal;
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(ConvertDigitToText(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintNumber(1.3, "f");
            PrintNumber(0.75, "%");
            PrintNumber(2.30, "r");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));

            bool horizontal = IsLineHorizontal(3, 3);
            Console.WriteLine("Horizontal? " + horizontal);

            bool vertical = IsLineVertical(-1, 2.5);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "Sofia", "17.03.1992");

            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results", "03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
