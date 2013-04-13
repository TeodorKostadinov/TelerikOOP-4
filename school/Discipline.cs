using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Discipline:Commentable
    {
        public string Name{get;set;}
        public int NumberLectures{get;set;}
        public int NumberExcersices{get;set;}
        public Discipline(string name)
        {
            this.Name = name;
        }
        public override void Comment()
        {
            Console.WriteLine("Make comment for a discipline");
        }
    }
}
