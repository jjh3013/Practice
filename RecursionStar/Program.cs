using System;

namespace RecursionStar
{
    class Program
    {
        static char[][] Val;
        static void Main(string[] args)
        {
            //숫자입력
            int Num = Convert.ToInt32(Console.ReadLine());

            Val = new char[Num][];

            for(int i = 0; i < Num; i ++)
            {
                Val[i] = new char[Num];
                for(int j = 0; j < Num; j++)
                {
                    Val[i][j] = ' ';
                }
            }

            ReStar(0, 0, Num);

            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine(Val[i]);
            }

        }
        static void ReStar(int a, int b, int Num)
        {
            if(Num == 1)
            {
                Val[a][b] = '*';
                return;
            }

            int div = Num / 3;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j ++)
                {
                    if(i == 1 && j == 1)
                    {
                        continue;
                    }
                    ReStar(a + (div * i), b + (div * j), div);
                }
            }
            return;
        }
    }
}
