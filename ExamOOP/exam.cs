using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public abstract class exam
    {
        //timeofExam, NoOfQuestions, List<Question>
        public int Time { get; set; }
        public int NoOfQuestions { get; set; }

        public question[] QuestionList { get; set; }
        public exam(int time, int noOfQuestion)
        {
            Time = time;
            NoOfQuestions = noOfQuestion;


        }

        public abstract void CreateQuestionList();
        public abstract void ShowExam();

    }
}
