using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Student : Person
    {
        public int Number{get;set;}
        public Student(string name)
        {
            this.Name = name;
        }
    }
}
