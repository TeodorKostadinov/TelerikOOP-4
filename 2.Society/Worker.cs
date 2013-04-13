using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Society
{
    class Worker:Human
    {
        public int WeekSalary{get;set;}
        public int WorkHoursPerDay{get;set;}
        public int MoneyPerHour()
        {
            return (this.WeekSalary/7)/this.WorkHoursPerDay;
        }
        public Worker(int salery,int hoursPerDay,string firstName,string secondName)
        {
            this.WeekSalary=salery;
            this.WorkHoursPerDay=hoursPerDay;
            base.FirstName = firstName;
            base.SecondName = secondName;
        }
    }
}
