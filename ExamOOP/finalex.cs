using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExamOOP.truefalse;

namespace ExamOOP
{
    public class finalex : exam
    {
        public finalex(int time, int noOfQuestion) : base(time, noOfQuestion)
        {
        }

        public override void CreateQuestionList()
        {
            QuestionList = new question[NoOfQuestions];
            for (int i = 0; i < QuestionList?.Length; i++)
            {
                int questionType;
                do
                {
                    Console.WriteLine("1 for MCQ || 2 For True&False");

                } while (int.TryParse(Console.ReadLine(), out questionType) && (questionType < 1 || questionType > 2));
                Console.Clear();
                if (questionType == 1)
                {
                    QuestionList[i] = new mcq();
                    
                }
                else
                {
                    QuestionList[i] = new truefalse();
                    
                }
            }
        }

        public override void ShowExam()
        {
            foreach (var question in questionlist)
            {
                Console.WriteLine(question.ToString());
                foreach (var answer in question)
                {
                    Console.WriteLine(answer.ToString());
                }
                //user Answer
                int userAnswerId;
                do
                {
                    Console.WriteLine("please Enter Your Answer: ");

                } while (!int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId < 1 || userAnswerId > 3));

               
            }
            
        }
    }
}
