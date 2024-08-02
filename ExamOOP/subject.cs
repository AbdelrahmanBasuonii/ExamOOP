using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class subject
    {
        //id, name, ExamSubject 
        public int Id { get; set; }
        public string Name { get; set; }
        public exam SubjectExam { get; set; }

        public subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void CreateExam()
        {
            int examType, time, noOfQuestion;
            do
            {
                Console.WriteLine("please choose the type of Exam[1 For Practical, 2 for Final]: ");
            } while (int.TryParse(Console.ReadLine(), out examType) && (examType < 1 || examType > 2));

            do
            {
                Console.WriteLine("please Enter the Duration of Exam: ");
            } while (int.TryParse(Console.ReadLine(), out time) && time < 1);
            do
            {
                Console.WriteLine("please Enter Number of Questions : ");
            } while (int.TryParse(Console.ReadLine(), out noOfQuestion) && noOfQuestion < 1);


            Console.Clear();
            SubjectExam.CreateQuestionList();


        }
        public void ShowExam()
        {
            SubjectExam.ShowExam();
        }
    }
}
