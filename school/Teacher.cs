﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Teacher:Person
    {
        public List<Discipline> Discplines { get; set; }
        public Teacher(string name)
        {
            this.Discplines = new List<Discipline>();
            this.Name = name;
        }
    }
}
