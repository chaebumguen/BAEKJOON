using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    class Program
    {
        static void Main(string[] args)
        {
            int TestFrequncy;

            string T = Console.ReadLine();

            bool NumberJudge = int.TryParse(T, out TestFrequncy);

            if(NumberJudge)
            {
                Console.WriteLine("x1, y1, r1, x2, y2, r2 순으로 정수를 입력해주세요. 공백 필수입니다. 테스트는 " + TestFrequncy + "번 진행하겠습니다.");
            }
            else
            {
                Console.WriteLine("잘못 입력했습니다.");
            }

            for (int i = 0; i < TestFrequncy; i++)
            {
                string[] Location = Console.ReadLine().Split();
            }
        }
    }
}
