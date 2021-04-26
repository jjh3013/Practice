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

            Val[0] = new int[1];
            Val[1] = new int[4];

            int k;
            Val[0][0] = N;
            Val[1][0] = N * 10 + N;
            Val[1][1] = N * N;
            Val[1][2] = N / N;
            Val[1][3] = N + N;

            if (Cor(Val[1], number) == 1)
            {
                return 2;
            }


            int MaxNumber;

            for (int i = 2; i < 8; i++)
            {
                MaxNumber = MaxNum(Val, i);

                Val[i] = new int[MaxNumber];
                Val[i] = loofNum(Val, MaxNumber, i);

                if (Cor(Val[i], number) == 1)
                {
                    return i;
                }
            }

            return answer;

        }

        public static int Cor(int[] NumList, int number)
        {
            for (int i = 0; i < NumList.Length; i++)
            {
                if (NumList[i] == number)
                {
                    return 1;
                }
            }
            return 0;
        }

        public static int []loofNum(int [][] NumList, int MaxNum, int number)
        {
            int[] list = new int[MaxNum];
            list[0] = NumList[number - 1][0] * 10 + NumList[0][0];
            int a = 1;
            for(int i = 1; i < number; i ++)
            {
                for(int j = 0; j < NumList[i].Length; j ++)
                {
                    for(int k = 0; k < NumList[number-i-1].Length; k++)
                    {
                        list[a] = NumList[i][j] + NumList[number - i][k];
                        a++;
                        list[a] = NumList[i][j] - NumList[number - i][k];
                        a++;
                        list[a] = NumList[i][j] * NumList[number - i][k];
                        a++;
                        if(NumList[number - i][k] != 0)
                        list[a] = NumList[i][j] / NumList[number - i][k];
                        a++;
                    }
                }
            }

            return list;
        }

        public static int MaxNum(int[][] NumList, int number)
        {
            int a = 1;
            for (int i = 1; i < number; i++)
            {
                for (int j = 0; j < NumList[i].Length; j++)
                {
                    for (int k = 0; k < NumList[number - i-1].Length; k++)
                    {
                        a++;
                        a++;
                        a++;
                        a++;
                    }
                }
            }
            return a;
        }
    }
}