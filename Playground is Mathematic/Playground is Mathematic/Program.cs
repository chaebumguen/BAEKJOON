using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_is_Mathematic
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate Playground = new Calculate("BreadCrab");

            int H = Convert.ToInt32(Console.ReadLine());
            Calculate.Condition(H);

            int W = Convert.ToInt32(Console.ReadLine());
            Calculate.Condition(W);

            double a;

            a = (Calculate.CalculationRcm(Calculate.SelectSmallNum(H, W)));

            Console.WriteLine(a);
        }
    }

    class Calculate
    {
        string s;

        public Calculate(string t)
        {
            s = t;
            Console.WriteLine(s);
        }

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