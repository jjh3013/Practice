using System;

namespace RecursionFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자입력
            int Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fibonacci(Num));
        }

        static int Fibonacci(int Num)
        {
            if (Num == 0)
            {
                return 0;
            }
            else if (Num == 1)
            {
                return 1;
            }

            return Fibonacci(Num - 1) + Fibonacci(Num - 2);
        }
    }
}
