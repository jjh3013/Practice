using System;

namespace Country124
{
    class Program
    {

        static void Main(string[] args)
        {
            //숫자 입력
            string InputNum = Console.ReadLine();
            //결과 int형 저장용
            int Num = Convert.ToInt32(InputNum);

            Console.WriteLine(solution(Num));
        }
        public static string solution(int n)
        {
            string answer = "";
            int mok = n - 1;
            int minus = 3;
            int nmg = mok % 3;

            //0, 1, 2 일때
            switch ((nmg) % 3)
            {
                case 0:
                    answer += "1";
                    break;
                case 1:
                    answer += "2";
                    break;
                case 2:
                    answer += "4";
                    break;
                default:
                    break;
            }
            mok = mok - minus;

            //돌면서 3의 제곱들 처리
            while (mok >= 0)
            {
                switch ((mok / minus) % 3)
                {
                    case 0:
                        answer = "1" + answer;
                        break;
                    case 1:
                        answer = "2" + answer;
                        break;
                    case 2:
                        answer = "4" + answer;
                        break;
                    default:
                        break;
                }
                minus = minus * 3;
                mok = mok - minus;
            }

            return answer;
        }
    }
}