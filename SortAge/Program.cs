using System;
using System.Text;

namespace SortAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            string[] sortAge = new string[200];
            StringBuilder S_Build = new StringBuilder();
            int age = 0;
            string name;
            for (int i = 0; i < Num; i++)
            {
                name = Console.ReadLine();
                age = Convert.ToInt32(name.Split(" ")[0]) - 1;
                name = name.Split(" ")[1];

                if (sortAge[age] == null)
                    sortAge[age] = name;
                else
                sortAge[age] = sortAge[age] + " " + name;
            }
            for (int i = 0; i < 200; i++)
            {
                if (sortAge[i] != null)
                {
                    foreach (string Name in sortAge[i].Split(" "))
                    {
                        S_Build.Append(i + 1 + " " + Name + "\n");
                    }
                }
            }
            Console.WriteLine(S_Build);
        }
    }
}
