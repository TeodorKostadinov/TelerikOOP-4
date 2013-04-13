using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Society
{
    class Human
    {
        private string firstName;
        private string secondName;
        public string FirstName 
        { 
            get{return this.firstName;}
            set { this.firstName = value; }
        }
        public string SecondName 
        { 
            get{return this.secondName;}
            set { this.secondName = value; }
        }
    }
}
