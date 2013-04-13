using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten:Cat
    {
        public Kitten(int age, string name)
            : base(age, name, "female")
        {
        }
        public Kitten(int age, string name,string sex)
            : base(age, name, "female")
        {
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Kitten: ");
            sb.Append(this.Name.ToString());
            sb.Append(" Sex: " + this.Sex.ToString());
            sb.Append(" Age: " + this.Age.ToString());
            return sb.ToString();
        }
    }
}
