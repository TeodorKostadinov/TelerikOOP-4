using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal:ISound
    {
        private int age;
        private string name;
        private string sex;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }
        public Animal(int anAge, string anName, string anSex)
        {
            this.Age = anAge;
            this.Name = anName;
            this.Sex = anSex;
        }
        virtual public void MakeSound()
        {
            Console.WriteLine("An animal Sound");
        }
        
    }
}
