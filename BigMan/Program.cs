using System;

namespace BigMan
{
    class Program
    {
        static void Main(string[] args)
        {
            //사람수 저장
            int Num = Convert.ToInt32(Console.ReadLine());
            int[][] Man = new int[Num][];

            for(int i = 0; i < Num; i ++)
            {
                Man[i] = new int[3];
                string InputWT = Console.ReadLine();
                //등수
                Man[i][0] = 1;
                //몸무게
                Man[i][1] = Convert.ToInt32(InputWT.Split(" ")[0]);
                //키
                Man[i][2] = Convert.ToInt32(InputWT.Split(" ")[1]);
            }

            for(int i = 0; i < Num; i ++)
            {
                for(int j = 0; j < Num; j ++)
                {
                    if(Man[i][1] < Man[j][1])
                    {
                        if(Man[i][2] < Man[j][2])
                        {
                            Man[i][0]++;
                        }
                    }
                }
            }

            for(int i = 0; i < Num; i ++)
            {
                Console.Write(Man[i][0]);
                Console.Write(" ");
            }
        }
    }
}
