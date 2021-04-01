using System;

namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputNum = Console.ReadLine();
            string[] _InputNum = InputNum.Split(",");
            int count = 0;
            string Result = null;
            int[] answer = new int[_InputNum.Length];

            for (int i = 0; i < _InputNum.Length; i++)
            {
                if(i > 0)
                {
                    Result += ",";
                }
                count = 0;
                int FN = Convert.ToInt32(_InputNum[i]);
                for(int j = i+1; j < _InputNum.Length; j++)
                {
                    int SN = Convert.ToInt32(_InputNum[j]);
                    if(FN > SN)
                    {
                        if(j < _InputNum.Length)
                        {
                            count++;
                        }
                        break;
                    }
                    count++;
                }
                Result += count;
                answer[i] = count;
            }

            Console.WriteLine(Result);
        }
    }
}

public class Solution
{
    public int[] solution(int[] prices)
    {
        int[] answer = new int[prices.Length];
        int count = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            count = 0;
            int FN = prices[i];
            for (int j = i + 1; j < prices.Length; j++)
            {
                int SN = prices[j];
                if (FN > SN)
                {
                    if (j < prices.Length)
                    {
                        count++;
                    }
                    break;
                }
                count++;
            }
            answer[i] = count;
        }

        return answer;
    }
}