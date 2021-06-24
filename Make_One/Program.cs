using System;

namespace Make_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int count = 0;
            n = Convert.ToInt32(Console.ReadLine());

            while(n != 1)
            {
                count++;
                if(n % 3 == 0)
                {
                    n = n / 3;
                }
                else if ((n - 1) % 3 == 0)
                {
                    n -= 1;
                }
                else if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n -= 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}
