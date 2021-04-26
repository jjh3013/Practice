using System;

namespace RecursionFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자입력
            int Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fac(Num));
        }

        static int Fac(int Num)
        {
            if(Num == 0)
            {
                return 1;
            }

            return Num * Fac(Num - 1);
        }
    }
}
