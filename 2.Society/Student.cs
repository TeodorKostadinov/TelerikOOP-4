using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Society
{
    class Student:Human
    {
        private byte grade;
        public byte Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
        public Student(byte hisGrade, string frstName, string scndName)
        {
            this.Grade = hisGrade;
            base.FirstName = frstName;
            base.SecondName = scndName;
        }
    }
}
