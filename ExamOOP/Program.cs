using System.Diagnostics;

namespace ExamOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            subject sub = new(1, "C#");
            sub.createExam();
            Console.Clear();
            char choice;
            do
            {
                Console.WriteLine("Do you want to take the exam: ");

            } while (!Char.TryParse(Console.ReadLine().ToLower(), out choice) && choice != 'y' && choice != 'n');
            if (choice == 'y')
            {
                Console.Clear();
                Stopwatch sw = Stopwatch.StartNew();

                sub.showExam();
                Console.WriteLine($"the Time taken for exam = {sw.Elapsed}");
            }
            if (choice == 'n')
            {
                Console.WriteLine("Thank you");
            }


        }
    }
}
