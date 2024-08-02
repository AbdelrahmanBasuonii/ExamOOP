using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class mcq : question
    {
        public override string Name { get => "mcq (choos one anser)"; }
        //public override string Marks { get => throw new NotImplementedException(); }
        //public override string Description { get => throw new NotImplementedException(); }
        //public override string Answr { get => throw new NotImplementedException(); }
        public override void addquestion()
        {
            Console.WriteLine(Name);
            Console.WriteLine("please enter the ques");
            Body = Console.ReadLine() ??"NOT NULL";



            Console.WriteLine("chice the mcq");
            anserList = new anser[3]; 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("please prees to chise number ");
                anserList[i] = new anser() { Text};
            }

            int rightAnswer;
            do
            {
                Console.WriteLine("please Specify Right Choice(1, 2, 3)");

            } while (int.TryParse(Console.ReadLine(), out rightAnswer) && (rightAnswer < 1 || rightAnswer > 3));

        }

        
    }
}
