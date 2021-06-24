using System;
using System.Text;

namespace NandM_1
{
    class Program
    {
        static int[] Seq;
        static bool[] Visit;
        static void Main(string[] args)
        {
            StringBuilder S_Build = new StringBuilder();

            string Co = (Console.ReadLine());
            int n = Convert.ToInt32(Co.Split(" ")[0]);
            int m = Convert.ToInt32(Co.Split(" ")[1]);
                        
            Seq = new int[m];

            Visit = new bool[n + 1];

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    Visit[j] = false;
                }
                Seq = new int[m];
                Seq[i] = i+1;
                Visit[i + 1] = true;
                Recur(m, i+1);
            }
        }

        static void Recur(int m, int i)
        {
            if (m != i)
            {
                Seq[i];
                Recur(m, i+1);
            }
        }
    }
}
