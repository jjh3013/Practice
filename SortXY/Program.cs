using System;
using System.Text;

namespace SortXY
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());

            int[][] sortNum = new int[Num][];

            StringBuilder S_Build = new StringBuilder();

            string xy;

            for (int i = 0; i < Num; i++)
            {
                xy = Console.ReadLine();
                sortNum[i] = new int[2];
                sortNum[i][0] = Convert.ToInt32(xy.Split(" ")[0]);
                sortNum[i][1] = Convert.ToInt32(xy.Split(" ")[1]);
            }

            Array.Sort(sortNum, (a, b) => a[0] != b[0] ? a[0].CompareTo(b[0]) : a[1].CompareTo(b[1]));

            for (int i = 0; i < Num; i++)
            {
                S_Build.Append(sortNum[i][0] +" "+ sortNum[i][1] + "\n");
            }

            Console.WriteLine(S_Build);
        }
    }
}
