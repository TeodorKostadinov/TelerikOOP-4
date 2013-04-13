using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class School
    {
        public string Name { get; set; }
        public List<Class> Classes{get;set;}

        public School(string schoolName)
        {
            this.Classes = new List<Class>();
            this.Name = schoolName;
        }
    }
}
