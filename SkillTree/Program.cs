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
                int SkillPoint;
                int SameSkill;

                for (int i = 0; i < skill_trees.Length; i++)
                {
                    SkillPoint = 0;
                    for (int j = 0; j < skill_trees[i].Length; j++)
                    {
                        if (SkillPoint == skill.Length)
                        {
                            answer++;
                            break;
                        }

                        SameSkill = 0;

                        for (int k = 0; k < skill.Length; k++)
                        {
                            if(skill[k] == skill_trees[i][j])
                            {
                                SameSkill = 1;
                                break;
                            }
                        }
                        if(SameSkill == 0)
                        {

                        }
                        else if (skill[SkillPoint] == skill_trees[i][j])
                        {
                            SkillPoint++;
                        }
                        else
                        {
                            break;
                        }

                        if(j == skill_trees[i].Length-1)
                        {
                            answer++;
                            break;
                        }
                    }
                }
                return answer;
            }
        }
    }
}