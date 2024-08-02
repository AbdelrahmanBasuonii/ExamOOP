using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public abstract class question
    {
        public abstract string Name { get;  }
        public abstract string Description { get; set; }
        public abstract string Marks { get; set; }
        public abstract string Answr { get; set; }

        public question(string name, string description, string marks, string answr)
        {
            name = name;
            Description = description;
            Marks = marks;
            Answr = new answr();
        }

        public abstract void addquestion();

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
