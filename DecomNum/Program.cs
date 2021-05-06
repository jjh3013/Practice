using System;

namespace DecomNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //입력값 저장
            int Num = Convert.ToInt32(Console.ReadLine());
            int answer = 0;

            for(int i = 0; i < Num; i ++)
            {
                answer = i;
                string calc = Convert.ToString(i);
                for(int j = 0; j < calc.Length; j++)
                {
                    answer += Convert.ToInt32(calc[j]-48);
                }
                if(answer == Num)
                {
                    answer = i;
                    break;
                }
                answer = 0;
            }

            Console.WriteLine(answer);
        }
    }
}
