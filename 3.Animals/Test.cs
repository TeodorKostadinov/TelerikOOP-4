using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create arrays of different kinds of animals 
//and calculate the average age of each kind of animal using a static method 
//It says ARRAYS so I assume i have to create an array for every kind of animal
namespace Animals
{
    class Test
    {
        static void Main()
        {
            Random rand = new Random();
            Dog[] dogs = new Dog[5];
            Frog[] frogs = new Frog[5];
            Cat[] cats = new Cat[5];
            Kitten[] kittens = new Kitten[5];
            Tomcat[] tomcats = new Tomcat[5];
            for (int i = 0; i < 5; i++)
            {
                int age=rand.Next(0,30);
                Dog dog = new Dog(age, Convert.ToString((char)(age + 65)), "male");
                dogs[i] = dog;

                age = rand.Next(0, 30);
                Frog frog = new Frog(age, Convert.ToString((char)(age + 65)), "male");
                frogs[i] = frog;

                age = rand.Next(0, 30);
                Kitten kiten = new Kitten(age, Convert.ToString((char)(age + 65)), "male");
                kittens[i] = kiten;

                age = rand.Next(0, 30);
                Cat cat = new Cat(age, Convert.ToString((char)(age + 65)), "male");
                cats[i] = cat;

                age = rand.Next(0, 30);
                Tomcat tomcat = new Tomcat(age, Convert.ToString((char)(age + 65)), "male");
                tomcats[i] = tomcat;
            }
            Print(dogs);
            Print(cats);
            Print(kittens);
            Print(frogs);
            Print(tomcats);
            Console.WriteLine("The average age of the dogs is {0}", AverageAge(dogs));
            Console.WriteLine("The average age of the cats is {0}", AverageAge(cats));
            Console.WriteLine("The average age of the kittens is {0}", AverageAge(kittens));
            Console.WriteLine("The average age of the frogs is {0}", AverageAge(frogs));
            Console.WriteLine("The average age of the tomcats is {0}", AverageAge(tomcats));

        }
        static double AverageAge(Animal[] animls)
        {
            double overalAge = 0;
            int count = 0;
            foreach (var animal in animls)
            {
                count++;
                overalAge = overalAge + animal.Age;
            }
            return overalAge / count;
        }
        public static void Print(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
