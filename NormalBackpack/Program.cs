using System;

namespace NormalBackpack
{
    class Program
    {
        static void Main(string[] args)
        {
            string Line = Console.ReadLine();
            int n = Convert.ToInt32(Line.Split(" ")[0]);
            int k = Convert.ToInt32(Line.Split(" ")[1]);

            int[][] WV = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Line = Console.ReadLine();
                WV[i] = new int[2];
                WV[i][0] = Convert.ToInt32(Line.Split(" ")[0]);
                WV[i][1] = Convert.ToInt32(Line.Split(" ")[1]);
            }
            Array.Sort(WV, (a, b) => a[1].CompareTo(b[1]));
            Array.Sort(WV, (a, b) => a[0].CompareTo(b[0]));

            int MaxV = 0;
            int SumV = 0;
            int SumW = 0;

            for (int i = 0; i < n; i++)
            {
                SumW = WV[i][0];
                if (SumW > k)
                    break;

                SumV = WV[i][1];

                if (MaxV < SumV)
                    MaxV = SumV;
                if (i + 1 == n)
                    break;

                Test(i);
            }

            Console.WriteLine(MaxV);

            void Test(int i)
            {
                for (int j = i + 1; j < n; j++)
                {
                    SumW += WV[j][0];
                    if (SumW > k)
                        break;

                    SumV += WV[j][1];

                    if (MaxV < SumV)
                        MaxV = SumV;
                    if (j + 1 == n)
                        break;
                    Test(j);
                }
            }
        }
    }
}
//wrong! [정답] != [오답]
//
//wrong! 14
//4 7
//6 13
//4 8
//3 6
//5 12
//wrong! 264 != 263
//7 19
//9 89
//8 80
//1 32
//6 68
//2 74
//3 42
//7 2
//wrong! 23 != 22
//6 9
//3 6
//2 7
//4 6
//4 2
//4 10
//1 5
//wrong! 31 != 29
//9 10
//1 8
//5 10
//4 10
//2 6
//4 5
//4 7
//3 7
//4 7
//1 4
//wrong! 26 != 25
//6 7
//3 7
//3 10
//1 6
//2 7
//3 5
//2 9
//wrong! 19 != 18
//7 9
//3 6
//2 4
//2 5
//3 4
//1 3
//4 1
//2 4
//wrong! 20 != 18
//7 7
//1 4
//3 1
//3 6
//2 6
//3 8
//3 4
//2 6
//wrong! 17 != 16
//5 9
//2 4
//1 3
//3 5
//4 8
//2 1
//wrong! 31 != 28
//8 9
//1 4
//2 7
//3 10
//2 7
//2 7
//4 8
//3 5
//4 1
//wrong! 38 != 37
//9 10
//4 2
//4 9
//1 5
//1 7
//2 8
//3 9
//2 8
//2 6
//3 5
//wrong! 21 != 20
//5 7
//3 8
//1 5
//2 7
//2 2
//2 6
//wrong! 30 != 29
//10 10
//1 2
//4 9
//1 5
//4 8
//4 1
//1 7
//3 2
//3 7
//2 5
//5 2
//wrong! 24 != 23
//9 7
//1 1
//1 4
//3 10
//2 1
//2 7
//3 8
//3 9
//3 3
//2 7
//wrong! 37 != 36
//9 9
//2 9
//1 7
//3 10
//2 2
//3 3
//4 9
//2 10
//2 8
//3 2