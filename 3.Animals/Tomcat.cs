using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat:Cat
    {
        public Tomcat(int age, string name)
            : base(age, name, "male")
        {
        }
        public Tomcat(int age, string name,string sex)
            : base(age, name, "male")
        {
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Tomcat: ");
            sb.Append(this.Name.ToString());
            sb.Append(" Sex: " + this.Sex.ToString());
            sb.Append(" Age: " + this.Age.ToString());
            return sb.ToString();
        }
    }
}
