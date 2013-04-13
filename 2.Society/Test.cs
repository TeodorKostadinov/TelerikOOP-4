using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Society
{
    class Test
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Student> setOfStudents = new List<Student>();
            List<Worker> setOfWorkers = new List<Worker>();
            List<Human> people=new List<Human>();
            //generating randomly students and workers
            for (int i = 0; i < 10; i++)
            {
                byte grade = (byte)rand.Next(2, 7);
                StringBuilder firstN=new StringBuilder();
                firstN.Append((char)(rand.Next(65, 88)));
                firstN.Append((char)(rand.Next(65, 88)));
                firstN.Append((char)(rand.Next(65, 88)));
                StringBuilder secondN=new StringBuilder();
                secondN.Append((char)(rand.Next(65, 88)));
                secondN.Append((char)(rand.Next(65, 88)));
                secondN.Append((char)(rand.Next(65, 88)));
                Student oneStudent = new Student(grade, firstN.ToString(), secondN.ToString());
                setOfStudents.Add(oneStudent);
                people.Add(oneStudent);
            }
            for (int i = 0; i < 10; i++)
            {
                StringBuilder firstN = new StringBuilder();
                firstN.Append((char)(rand.Next(65, 88)));
                firstN.Append((char)(rand.Next(65, 88)));
                firstN.Append((char)(rand.Next(65, 88)));
                StringBuilder secondN = new StringBuilder();
                secondN.Append((char)(rand.Next(65, 88)));
                secondN.Append((char)(rand.Next(65, 88)));
                secondN.Append((char)(rand.Next(65, 88)));
                Worker oneWorker = new Worker(rand.Next(200, 500), rand.Next(2, 12), firstN.ToString(), secondN.ToString());
                setOfWorkers.Add(oneWorker);
                people.Add(oneWorker);
            }
            //sorting
            var studentByGrade = from oneStudent in setOfStudents
                                 orderby oneStudent.Grade
                                 select oneStudent;
            var workersByMoneyPerHour = from oneWorker in setOfWorkers
                                        orderby oneWorker.MoneyPerHour()
                                        select oneWorker;
            var allHumansByFirstLastName = from person in people
                                           orderby person.FirstName,person.SecondName
                                           
                                           select person;

            //Printing
            Console.WriteLine("Students by grade:");
            foreach (var student in studentByGrade)
            {
                Console.WriteLine("{0} {1} {2}",student.Grade,student.FirstName,student.SecondName);
            }
            Console.WriteLine();
            Console.WriteLine("Workers by Money per Hour: ");
            foreach (var worker in workersByMoneyPerHour)
            {
                Console.WriteLine("{0} {1} {2} WeeklySalary: {3}, Hours/Day: {4}",worker.MoneyPerHour(),worker.FirstName,worker.SecondName,worker.WeekSalary,worker.WorkHoursPerDay);
            }
            Console.WriteLine();
            Console.WriteLine("All people by first and last name");
            foreach (var person in allHumansByFirstLastName)
            {
                Console.WriteLine("{0} {1}",person.FirstName,person.SecondName);
            }
        }
    }
}
