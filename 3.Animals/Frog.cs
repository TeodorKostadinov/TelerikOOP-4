using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog:Animal
    {
        public Frog(int age, string name, string sex)
            : base(age, name, sex)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Wibbit");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Frog: ");
            sb.Append(this.Name.ToString());
            sb.Append(" Sex: " + this.Sex.ToString());
            sb.Append(" Age: " + this.Age.ToString());
            return sb.ToString();
        }
    }
}
