using System;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());

            int[] sortNum = new int[Num];
            int Sum = 0;

            for (int i = 0; i < Num; i++)
            {
                sortNum[i] = Convert.ToInt32(Console.ReadLine());
                Sum += sortNum[i];
            }
        }
    }
}
