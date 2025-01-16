using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Exam.Models
{
    internal class PracticalExam : Exam
    {
        MCQ[] Questions;
        public override void Create()
        {

            #region Time
            bool flag = true;
            int time=30;
            do
            {
                if (!flag||time<30 |time>180)
                {
                    Console.WriteLine("Invalid Time.");
                }
                Console.WriteLine("Enter Exam Time (30:180) Minutes : ");
                flag = int.TryParse(Console.ReadLine(), out time);
            } while (!flag || time<30 || time>180);
            Time = time;

            #endregion

            #region Number of questions
            int number;
            do
            {
                if (!flag)
                {
                    Console.WriteLine("Invalid number.");
                }
                Console.WriteLine("Enter number of questions : ");
                flag = int.TryParse(Console.ReadLine(), out number);
            } while (!flag || number < 0);
            NumberOfQuestion = number;
            Questions = new MCQ[number];
            #endregion

            #region Questions
            for (int i = 0; i < NumberOfQuestion; i++)   
            {
                #region Question
                Console.WriteLine($"Enter Question {i + 1} : ");
                Questions[i] = new MCQ();
                Questions[i].Header = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter Choice ({j + 1}) :");
                    Questions[i].Answers[j].Text = Console.ReadLine();
                }
                #endregion

                #region Right Answer
                number = 1;
                do
                {
                    if (!flag || number < 0 || number > 3)
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    Console.WriteLine("Enter The Right Choice Number : ");
                    flag = int.TryParse(Console.ReadLine(), out number);
                } while (!flag || number < 0 || number > 3);
                Questions[i].RightAnswerId = number;
                #endregion

                #region Mark
                do
                {
                    if (!flag)
                    {
                        Console.WriteLine("Invalid Mark.");
                    }
                        Console.WriteLine("Enter Question Mark :");
                    flag = int.TryParse(Console.ReadLine(), out number);
                } while (!flag || number < 0);
                Questions[i].Mark = number;
                #endregion

               

            }
            #endregion
        }

        public override void Start()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = 0,total=0;
            int[] Choices = new int[NumberOfQuestion];
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                System.Console.Clear();
                Console.WriteLine($"Q {i+1}. {Questions[i].Header}");
                for (int j = 0; j < Questions[i].Answers.Length; j++)
                {
                    Console.WriteLine($"{j+1}. {Questions[i].Answers[j].Text}");
                }
                bool flag = true;
                int number = 1;
                do
                {
                    if (!flag || number < 1 || number > 3)
                    {
                        Console.WriteLine("Invalid Choice.");
                    }
                    Console.WriteLine("Enter Choice Number : ");
                    flag= int.TryParse(Console.ReadLine(),out number);
                } while (!flag || number <1 || number > 3);
                Choices[i] = number;
            }
            System.Console.Clear();

            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.WriteLine($"Q {i+1}. Your Choice : {Questions[i].Answers[Choices[i]-1]}");
                Console.WriteLine($"  Correct Choice : {Questions[i].Answers[Questions[i].RightAnswerId-1]}");
                total += Questions[i].Mark;
                if (Choices[i] == Questions[i].RightAnswerId)
                    result += Questions[i].Mark;
            }
            Console.WriteLine($"You scored {result} out of {total} Points");
            stopwatch.Stop();

            Console.WriteLine(value: $"Time taken is # {stopwatch.Elapsed}");
        }
    }
}
