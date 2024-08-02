using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public abstract class truefalse
    {
        public class truefalse : question
        {
            public override string name => "True OR False Question";



            public truefalse()
            {
                answerList = new answer[2]
                {
                new answer(1, "True"),
                new answer(2, "False")
                };
            }

            public override void addQuestion()
            {
                Console.WriteLine(name);

                Console.WriteLine("Please enter the body of Question");
                body = Console.ReadLine() ?? "No Question Found";

                int mark;
                do
                {
                    Console.WriteLine("please enter the mark of Question");

                } while (int.TryParse(Console.ReadLine(), out mark) && mark < 1);
                mark = mark;


                int rightAnswer;
                do
                {
                    Console.WriteLine("please Specify Right Choice(1 For True, 2 For False )");

                } while (int.TryParse(Console.ReadLine(), out rightAnswer) && (rightAnswer < 1 || rightAnswer > 2));


            }

            public override void addquestion()
            {
                throw new NotImplementedException();
            }
        }
    }
}
