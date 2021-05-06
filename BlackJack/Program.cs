using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputNum = Console.ReadLine();
            //카드의 개수
            int CardN = Convert.ToInt32(InputNum.Split(" ")[0]);
            //카드 합
            int CardM = Convert.ToInt32(InputNum.Split(" ")[1]);

            InputNum = Console.ReadLine();
            //카드들
            int[] Card = new int[CardN];

            for(int i = 0; i < CardN; i++)
            {
                Card[i] = Convert.ToInt32(InputNum.Split(" ")[i]);
            }

            int answer = 0;

            for(int i = 0; i < CardN - 2; i++)
            {
                for(int j = i+1; j < CardN - 1; j++)
                {
                    for(int k = j+1; k < CardN; k++)
                    {
                        if((Card[i] + Card[j] + Card[k] > answer) && (CardM >= Card[i] + Card[j] + Card[k]))
                        {
                            answer = Card[i] + Card[j] + Card[k];
                        }
                    }
                }
            }

            Console.WriteLine(answer);

        }
    }
}
