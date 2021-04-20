using System;

namespace SkillTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열 입력
            string Skill = Console.ReadLine();
            string InputSkillT = Console.ReadLine();
            //쉼표로 자름
            string[] Skill_Trees = InputSkillT.Split(",");

            Console.WriteLine(solution(Skill, Skill_Trees));


            int solution(string skill, string[] skill_trees)
            {
                int answer = 0;
                int SkillPoint = 0;

                for (int i = 0; i < skill_trees.Length; i++)
                {
                    SkillPoint = 0;
                    for (int j = 0; j < skill_trees[i].Length; j++)
                    {
                    }
                }


                return answer;
            }

        }
    }
}