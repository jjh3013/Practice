using System;
using System.Text;

namespace SortWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());

            string[] sortWord = new string[Num];

            StringBuilder S_Build = new StringBuilder();

            for (int i = 0; i < Num; i++)
            {
                sortWord[i] = Console.ReadLine();
                for (int j = 0; j < i; j++)
                {
                    if (sortWord[i].Length < sortWord[j].Length)
                    {
                        string temp = sortWord[i];
                        Array.Copy(sortWord, j, sortWord, j + 1, Num - j - 1);
                        sortWord[j] = temp;
                        break;
                    }
                    else if(sortWord[i].Length == sortWord[j].Length)
                    {
                        if (sortWord[i] == sortWord[j])
                        {
                            i--;
                            Num--;
                            break;
                        }
                        else if (string.Compare(sortWord[i], sortWord[j]) < 0)
                        {
                            string temp = sortWord[i];
                            Array.Copy(sortWord, j, sortWord, j + 1, Num - j - 1);
                            sortWord[j] = temp;
                            break;
                        }

                    }
                }
            }
            for (int i = 0; i < Num; i++)
            {
                S_Build.Append(sortWord[i] + "\n");
            }

            Console.WriteLine(S_Build);
        }
    }
}
