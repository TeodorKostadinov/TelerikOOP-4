using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat:Animal
    {
        public Cat(int age, string name, string sex)
            : base(age,  name,  sex)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cat: ");
            sb.Append(this.Name.ToString());
            sb.Append(" Sex: " + this.Sex.ToString());
            sb.Append(" Age: " + this.Age.ToString());
            return sb.ToString();
        }
    }
}
