using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Exam.Models
{
    internal class FinalExam : Exam
    {
        Question[] Questions;
        public override void Create()
        {
            #region Time
            bool flag = true;
            int time = 30;
            do
            {
                if (!flag || time < 30 | time > 180)
                {
                    Console.WriteLine("Invalid Time.");
                }
                Console.WriteLine("Enter Exam Time (30:180) Minutes : ");
                flag = int.TryParse(Console.ReadLine(), out time);
            } while (!flag || time < 30 || time > 180);
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
            Questions = new Question[number];
            #endregion

            #region Questions
            for (int i = 0; i < NumberOfQuestion; i++)
            {

                #region Question Type
                int type = 1;
                do
                {
                    if (!flag || type > 2 || type < 1)
                    {
                        Console.WriteLine("Invalid Type.");
                    }
                    Console.WriteLine($"Enter Question {i + 1} Type (1 for MCQ : 2 for T&F)");
                    flag= int.TryParse(Console.ReadLine(),out type);
                } while (!flag || type > 2 || type < 1);
                #endregion

                if (type == 1)
                {
                    #region MCQ
                    Console.WriteLine($"Enter Question {i + 1} : ");
                    Questions[i] = new MCQ();
                    Questions[i].Header = Console.ReadLine();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Enter Choice ({j + 1}) :");
                        Questions[i].Answers[j].Text = Console.ReadLine();
                    }

                    number = 1;
                    do
                    {
                        if (!flag || number < 1 || number > 3)
                        {
                            Console.WriteLine("Invalid number.");
                        }
                        Console.WriteLine("Enter The Right Choice Number : ");
                        flag = int.TryParse(Console.ReadLine(), out number);
                    } while (!flag || number < 0 || number > 3);
                    Questions[i].RightAnswerId = number;
                    #endregion
                }
                else
                {
                    #region True or False
                    Console.WriteLine($"Enter Question {i + 1} : ");
                    Questions[i] = new TrueOrFalse();
                    Questions[i].Header = Console.ReadLine();

                    number = 1;
                    do
                    {
                        if (!flag || number < 1 || number > 2)
                        {
                            Console.WriteLine("Invalid number.");
                        }
                        Console.WriteLine("Enter The Right Choice Number :(1 for True : 2 for False )");
                        flag = int.TryParse(Console.ReadLine(), out number);
                    } while (!flag || number < 1 || number > 2);
                    Questions[i].RightAnswerId = number;
                    #endregion

                }

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

            int result = 0, total = 0;
            int[] Choices = new int[NumberOfQuestion];
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                System.Console.Clear();
                Console.WriteLine($"Q {i + 1}. {Questions[i].Header}");
                for (int j = 0; j < Questions[i].Answers.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {Questions[i].Answers[j].Text}");
                }
                bool flag = true;
                int number = 1;
                do
                {
                    if (!flag || number < 1 || number > Questions[i].Answers.Length)
                    {
                        Console.WriteLine("Invalid Choice.");
                    }
                    Console.WriteLine("Enter Choice Number : ");
                    flag = int.TryParse(Console.ReadLine(), out number);
                } while (!flag || number < 1 || number > Questions[i].Answers.Length);
                Choices[i] = number;
            }
            System.Console.Clear();

            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.WriteLine($"Q {i+1}. {Questions[i].Header}");
                Console.WriteLine($"Your Choice : {Questions[i].Answers[Choices[i] - 1]}");
                Console.WriteLine($"Correct Choice : {Questions[i].Answers[Questions[i].RightAnswerId - 1]}");
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
