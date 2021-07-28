using System;

namespace Electric_Flex
{
    class Program
    {
        struct LINE
        {
            public int Left;
            public int Right;
        };
        bool Cmp(LINE A, LINE B)
        {
            if (A.Left < B.Left) return true;
            return false;
        }

        static void Main(string[] args)
        {

            int[] DP = new int[101];
            LINE[] Line = new LINE[101];
            int n = Convert.ToInt32(Console.ReadLine());

            string lr;
            for (int i = 1; i <= n; i++)
            {
                lr = Console.ReadLine();
                Line[i].Left = Convert.ToInt32(lr.Split(" ")[0]);
                Line[i].Right = Convert.ToInt32(lr.Split(" ")[1]);
            }

            int Max(int A, int B) { if (A > B) return A; return B; }

            int Correct_Line = 0;

            Array.Sort(Line + 1, Line + n + 1, Cmp);

            for (int i = 1; i <= n; i++)
            {
                DP[i] = 1;
                for (int j = 1; j < i; j++)
                {
                    if (Line[i].Right > Line[j].Right)
                    {
                        DP[i] = Max(DP[i], DP[j] + 1);
                    }
                }
                Correct_Line = Max(Correct_Line, DP[i]);
            }

            Console.WriteLine(n - Correct_Line);
        }
    }
}
