using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog:Animal
    {
        public Dog(int age, string name, string sex)
            : base(age,name, sex)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Ruf-ruf");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Dog: ");
            sb.Append(this.Name.ToString());
            sb.Append(" Sex: " + this.Sex.ToString());
            sb.Append(" Age: " + this.Age.ToString());
            return sb.ToString();
        }
    }
}
