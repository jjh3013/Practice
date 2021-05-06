using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputMN = Console.ReadLine();
            //세로줄
            int M = Convert.ToInt32(InputMN.Split(" ")[0]);
            //가로줄
            int N = Convert.ToInt32(InputMN.Split(" ")[1]);

            int[][] Board = new int[M][];

            int Finalanswer = 64;
            int answer = 0;
            int a = 0;
            for (int i = 0; i < M; i++)
            {
                Board[i] = new int[N];
                string InputBW = Console.ReadLine();
                for(int j = 0; j < N; j ++)
                {
                    if (InputBW[j] == 'W')
                    {
                        Board[i][j] = 0;
                    }
                    else
                    {
                        Board[i][j] = 1;
                    }
                }
            }
            for(int i = 0; i < M-7; i++)
            {
                for(int j = 0; j < N-7; j++)
                {
                    //WB순서 확인
                    answer = 0;
                    a = 0;
                    for(int k = i; k < i+8; k++)
                    {
                        for(int l = j; l < j+8; l++)
                        {
                            if(Board[k][l] != a%2)
                            {
                                answer++;
                            }
                            a++;
                        }
                        a++;
                    }
                    if(Finalanswer > answer)
                    {
                        Finalanswer = answer;
                    }
                    //BW순서 확인
                    answer = 0;
                    a = 1;
                    for (int k = i; k < i + 8; k++)
                    {
                        for (int l = j; l < j + 8; l++)
                        {
                            if (Board[k][l] != a % 2)
                            {
                                answer++;
                            }
                            a++;
                        }
                        a++;
                    }
                    if (Finalanswer > answer)
                    {
                        Finalanswer = answer;
                    }
                }
            }
            Console.WriteLine(Finalanswer);
        }
    }
}
