using System;
using System.Linq;
using System.Text;

namespace NumSort_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());

            int[] sortNum = new int[Num];

            StringBuilder S_Build = new StringBuilder();
            
            for (int i = 0; i < Num; i++)
            {
                sortNum[i] = Convert.ToInt32(Console.ReadLine());
                //for(int j = 0; j < i; j++)
                //{
                //    if(sortNum[i] < sortNum[j])
                //    {
                //        int temp = sortNum[i];
                //        Array.Copy(sortNum, j, sortNum, j + 1, Num - j - 1);
                //        sortNum[j] = temp;
                //        break;
                //    }
                //}
            }

            Array.Sort(sortNum);

            //sortNum = sortNum.OrderBy(c => c).ToArray();

            foreach (int value in sortNum)
            {
                //Console.WriteLine(value);
                S_Build.Append(value + "\n");
            }


            Console.WriteLine(S_Build);
        }
    }
}
