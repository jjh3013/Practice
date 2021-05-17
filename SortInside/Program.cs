using System;
using System.Linq;

namespace SortInside
{
    class Program
    {
        static void Main(string[] args)
        {
            string Num = Console.ReadLine();

            int[] sortNum = new int[Num.Length];

            for (int i = 0; i < Num.Length; i++)
            {
                sortNum[i] = Convert.ToInt32(Num[i] - 48);
            }

            sortNum = sortNum.OrderByDescending(c => c).ToArray();

            foreach (int value in sortNum)
            {
                Console.Write(value);
            }
        }
    }
}
