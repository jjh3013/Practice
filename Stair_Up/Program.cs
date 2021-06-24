using System;

namespace Stair_Up
{
    class Program
    {
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        static void Main(string[] args)
        {
            int n;
            int []stair = new int[301];
            int[] dp = new int[301];

            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                stair[i] = Convert.ToInt32(Console.ReadLine());
            }

            dp[0] = stair[0];
            dp[1] = Max(stair[0] + stair[1], stair[1]);
            dp[2] = Max(stair[0] + stair[2], stair[1] + stair[2]);

            for (int i = 3; i < n; i++)
            {
                dp[i] = Max(dp[i - 2] + stair[i], stair[i - 1] + stair[i] + dp[i - 3]);
            }

            Console.WriteLine(dp[n - 1]);
        }
    }
}
