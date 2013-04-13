using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Test
    {
        static void Main()
        {
            School pmg = new School("PMG");
            pmg.Classes.Add(new Class("A"));
            pmg.Classes.Add(new Class("B"));
            foreach (var clas in pmg.Classes)
            {
                clas.SetOfStudents.Add(new Student("Pesho"));
                clas.SetOfStudents.Add(new Student("Gosho"));
                clas.SetOfTeachers.Add(new Teacher("Kolev"));
                clas.SetOfTeachers.Add(new Teacher("Todorov"));
                foreach (var teacher in clas.SetOfTeachers)
                {
                    teacher.Discplines.Add(new Discipline("Algebra"));
                    teacher.Discplines.Add(new Discipline("PE"));

                }
            }

        }
    }
}
