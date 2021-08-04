using System;

namespace ContinueSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Num = new int[n+1];

            string All_Num = Console.ReadLine();
            string[] S_Num = All_Num.Split(" ");
            for (int i = 1; i <= n; i++)
            {
                Num[i] = Convert.ToInt32(S_Num[i - 1]);
            }

            int Max_Num = Num[1];

            if (n > 1)
            {
                int DP = Num[1];
                if (DP < 0)
                    DP = 0;
                for (int i = 2; i <= n; i++)
                {
                    DP += Num[i];
                    if ((Max_Num < DP))
                        Max_Num = DP;
                    if (DP < 0)
                        DP = 0;
                }
            }
            Console.WriteLine(Max_Num);
        }
    }
}
