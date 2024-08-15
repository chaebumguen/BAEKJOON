using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Playground_is_Mathematic.Calculate;

namespace Playground_is_Mathematic
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            int H = Convert.ToInt32(Console.ReadLine());
            Condition(H);

            int W = Convert.ToInt32(Console.ReadLine());
            Condition(W);

            a = (CalculationRcm(SelectSmallNum(H, W)));

            Console.WriteLine(a);
        }
    }

    class Calculate
    {
        public static void Condition(int Meter)
        {
            if (Meter < 5 || Meter > 1000)
            {
                return;
            }
        }

        public static int SelectSmallNum(int a, int b)
        {
            int number = a;

            if (a > b)
            {
                number = b;

                return number;
            }
            else
            {
                return number;
            }
        }

        public static double CalculationRcm(int a)
        {
            double Width = 100 * (Convert.ToDouble(a) / 2);

            return Width;
        }
    }
}