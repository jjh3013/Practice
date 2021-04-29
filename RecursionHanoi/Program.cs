using System;
using System.Text;

namespace RecursionHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int disks = InputNumber(Console.ReadLine()); //원반 갯수 입력
            Console.WriteLine(Math.Pow(2, disks) - 1); //총 이동 횟수

            StringBuilder sb = new StringBuilder();
            SolveHanoi(sb, disks, 1, 3);
            Console.WriteLine(sb.ToString());
        }

        static void SolveHanoi(StringBuilder sb, int disks, int fromPeg, int toPeg)
        {
            //탈출 조건
            if (disks == 0)
                return;

            int sparePeg = 6 - fromPeg - toPeg;

            //재귀 조건
            SolveHanoi(sb, disks - 1, fromPeg, sparePeg);
            sb.AppendFormat("{0} {1}\n", fromPeg, toPeg);
            SolveHanoi(sb, disks - 1, sparePeg, toPeg);
        }

        static int InputNumber(string input)
        {
            int number = int.Parse(input);
            return number;
        }
    }
}