﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class anser
    {
        public int Id { get; set; } 
        public string Text { get; set; }


        public anser(int id, string text) 
        {
            Id = id;
            Text = text;
        }

        public override string ToString() 
        {  
            return $"{Id}.{Text}";
        }
    }
}
