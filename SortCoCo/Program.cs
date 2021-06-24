using System;
using System.Text;

namespace SortCoCo
{    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            int[][] sortCo = new int[Num][];
            StringBuilder S_Build = new StringBuilder();
            string Co = (Console.ReadLine());
            for(int i = 0; i < Num; i++)
            {
                sortCo[i] = new int[3];
                sortCo[i][0] = i;
                sortCo[i][1] = Convert.ToInt32(Co.Split(" ")[i]);
            }
            Array.Sort(sortCo, (a, b) =>a[1].CompareTo(b[1]));
            sortCo[0][2] = 0;
            int count = 0;
            for(int i = 0; i < Num - 1; i++)
            {
                if(sortCo[i][1] != sortCo[i+1][1])
                {
                    count++;
                }
                sortCo[i+1][2] = count;
            }
            Array.Sort(sortCo, (a, b) => a[0].CompareTo(b[0]));
            for(int i = 0; i < Num; i ++)
            {
                S_Build.Append(sortCo[i][2] + " ");
            }
            Console.WriteLine(S_Build);
        }
    }
}
