using System;

namespace practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열 입력
            string InputNum = Console.ReadLine();
            //쉼표로 자름
            string[] _InputNum = InputNum.Split(",");
            //몇번째 숫자를 찾는지 추적
            int location = Convert.ToInt32(Console.ReadLine());
            //결과 int형 저장용
            int[] answer = new int[_InputNum.Length];

            //int형배열로 변환
            for (int i = 0; i < _InputNum.Length; i++)
            {
                answer[i] = Convert.ToInt32(_InputNum[i]);
            }

            int len = answer.Length;
            int[] result = new int[len];

            //정렬해줌
            for(int i = 0; i < len-1; i++)
            {
                //if(location < i)
                //{
                //    break;
                //}
                for(int j = i+1; j < len; j++)
                {
                    if(answer[i] < answer[j])
                    {
                        if(location == i)
                        {
                            location = len - 1;
                        }
                        else
                        {
                            location--;
                        }
                        result[len - 1] = answer[i];
                        Array.Copy(answer, i + 1, result, i, len - i - 1);
                        Array.Copy(result, i, answer, i, len - i);
                        j = i;
                    }
                }
            }

            //결과출력
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(answer[i]);
            }
            Console.WriteLine(location+1);


        }
    }
}



public class Solution
{
    public int solution(int[] priorities, int location)
    {

        int[] answer = priorities;
        int len = answer.Length;
        int[] result = new int[len];

        for (int i = 0; i < len - 1; i++)
        {
            if (location < i)
            {
                break;
            }
            for (int j = i + 1; j < len; j++)
            {
                if (answer[i] < answer[j])
                {
                    if (location == i)
                    {
                        location = len - 1;
                    }
                    else
                    {
                        location--;
                    }
                    result[len - 1] = answer[i];
                    Array.Copy(answer, i + 1, result, i, len - i - 1);
                    Array.Copy(result, i, answer, i, len - i);
                    j = i;
                }
            }
        }
        location++;
        return location;
    }
}