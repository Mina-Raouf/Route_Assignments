using Exam.Models;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Route = new Subject();
            int ExamType = 1;
            bool flag = true;
            do
            {
                if (!flag || ExamType > 2 || ExamType < 1)
                {
                    Console.WriteLine("Invalid Type.");
                }
                Console.WriteLine("Enter Exam Type (1 for Final : 2 for Practical)");
                flag = int.TryParse(Console.ReadLine(), out ExamType);
            } while (!flag || ExamType > 2 || ExamType < 1);

            if (ExamType == 1)
            {
                Route.exam = new FinalExam();
            }
            else
            {
                Route.exam = new PracticalExam();
            }
            Route.exam.Create();
            string answer = "Y";
            do
            {
                if (answer != "Y" && answer != "N")
                {
                    Console.WriteLine("Invalid Reply.");
                }
                Console.WriteLine("Do you want to start the exam (Y/N)");
                answer = Console.ReadLine();
                answer=answer.ToUpper();
            } while (answer != "Y" && answer != "N");
            if (answer == "Y")
                Route.exam.Start();
        }
    }
}
