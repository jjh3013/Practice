using System;

namespace NNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자 입력
            string InputN = Console.ReadLine();
            string InputNum = Console.ReadLine();

            //결과 int형 저장용
            int N = Convert.ToInt32(InputN);
            int Num = Convert.ToInt32(InputNum);

            Console.WriteLine(solution(N, Num));
        }
        public static int solution(int N, int number)
        {
            if(N == number)
            {
                return 1;
            }

            int answer = -1;
            int[][] Val = new int[8][];
            int k;

            Val[0][0] = N;
            Val[1][0] = N * 10 + N;
            Val[1][1] = N * N;
            Val[1][2] = N / N;
            Val[1][3] = N + N;

            if(Cor(Val[1], number) == 1)
            {
                return 2;
            }

            for (int i = 2; i < 8; i ++)
            {
                Val[i][0] = Val[i - 1][0] * 10 + N;
                k = 1;
                if (i % 2 == 0)
                {
                    for (int j = 0; j < Val[i - 1].Length; j++)
                    {
                        Val[i][k] = Val[i - 1][j] + N;
                        k++;
                        Val[i][k] = Val[i - 1][j] - N;
                        k++;
                        Val[i][k] = Val[i - 1][j] * N;
                        k++;
                        Val[i][k] = Val[i - 1][j] / N;
                        k++;
                    }
                }
                else
                {
                    for (int j = 0; j < Val[i - 1].Length; j++)
                    {
                        Val[i][k] = Val[i - 1][j] + N;
                        k++;
                        Val[i][k] = Val[i - 1][j] - N;
                        k++;
                        Val[i][k] = Val[i - 1][j] * N;
                        k++;
                        Val[i][k] = Val[i - 1][j] / N;
                        k++;
                    }
                }

                if (Cor(Val[i], number) == 1)
                {
                    return i + 1;
                }

            }

            int Cor(int [] NumList, int number)
            {
                for(int i = 0; i < NumList.Length; i++)
                {
                    if(NumList[i] == number)
                    {
                        return 1;
                    }
                }
                return 0;
            }


            return answer;
        }
    }
}