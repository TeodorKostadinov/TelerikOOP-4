using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    abstract class Person:Commentable
    {
        public string Name{get;set;}

        public override void Comment()
        {
            Console.WriteLine("Make comment for a person");
        }
    }
}
