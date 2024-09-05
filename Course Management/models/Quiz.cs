using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Management.models
{
    public class Quiz
    {
        private string QuizID;
        private string Title;
        private string[] Questions;
        private string Answer;
        private int ScoreAdd = 0;
        private int ScoreSub = 0;

        public Quiz(string id, string title, string[] questions)
        {
            QuizID = id;
            Title = title;
            Questions = questions;
        }
        public void OperateQuizes()
        {
            Console.WriteLine($"========Best OF Luck=========");
            Console.WriteLine($"Quiz Topic: {Title} | Each Question: 1 mark\n-----------------------------------------------------");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Questions[i]}");
                Console.Write($" Answer: ");
                Answer = Console.ReadLine().ToLower();
                CheckQuizes(Answer);
            }
        }
        private void CheckQuizes(string ans)
        {
            switch (ans)
            {
                case "dhaka":
                    ScoreAdd++;
                    break;
                case "6":
                    ScoreAdd++;
                    break;
                case "money":
                    ScoreAdd++;
                    break;
                case "dr. yunus":
                    ScoreAdd++;
                    break;
                case "9":
                    ScoreAdd++;
                    break;
                default:
                    ScoreSub--;
                    break;
            }
        }
        public void Marks()
        {
            Console.WriteLine($"*---------Result----------*");
            if (ScoreAdd != 0)
            {
                Console.WriteLine($"Total Marks: 5");
                Console.WriteLine($"Correct Answer: {ScoreAdd}");
                if (ScoreAdd == 5)
                {
                    Console.WriteLine($"Congratulations! All Correct.");
                }
                else
                {
                    Console.WriteLine($"Total Mistakes: {Math.Abs(ScoreSub)}");
                }
                Console.WriteLine($"Overall: {ScoreAdd}");
            }
            else
            {
                Console.WriteLine($"Total Marks: 5");
                Console.WriteLine($"Total Mistakes: {Math.Abs(ScoreSub)}");
                Console.WriteLine($"Sorry! You did not pass the Exam. Better Luck Next Time.");
            }
            Console.WriteLine($"*----------*---------*");
        }
    }
}