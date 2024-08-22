using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        public static int InputNumWithLimit(int minN, int maxN)
        {
            int N;

            while (true)
            {
                N = Convert.ToInt32(Console.ReadLine());

                if (N >= minN && N <= maxN)
                {
                    break;
                }

                Console.WriteLine("Input number again");
            }

            return N;
        }

        static void Main(string[] args)
        {
            int TestFreq = InputNumWithLimit(1, 10);

            for (int i = 0; i < TestFreq; i++)
            {
                string str = Convert.ToString(Console.ReadLine());

                if (str.Length == 1)
                {
                    char ch = Convert.ToChar(str);
                    Console.WriteLine("{0}" + "{0}", ch, ch);
                }
                else if (str.Length == 2)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine(str.Remove(1, str.Length - 2));
                }
            }
        }
    }
}
