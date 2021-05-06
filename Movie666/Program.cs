using System;

namespace Movie666
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());

            int N = 0;
            int answer = 666;
            string s_answer;
            string c_answer;

            while(true)
            {
                s_answer = Convert.ToString(answer);
                c_answer = s_answer.Split("666")[0];

                if(s_answer != c_answer)
                {
                    N++;
                    if(N == Num)
                    {
                        break;
                    }
                }
                answer++;
            }

            Console.WriteLine(answer);
        }
    }
}
