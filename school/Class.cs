using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Class:Commentable
    {
        public List<Teacher> SetOfTeachers{get;set;}
        public List<Student> SetOfStudents { get; set; }
        public string ClassID { get; set; }

        public Class(string ClassID)
        {
            this.ClassID = ClassID;
            this.SetOfTeachers = new List<Teacher>();
            this.SetOfStudents = new List<Student>();          
        }
        public override void Comment()
        {
            Console.WriteLine("Make comment for class");
        }
    }
}
