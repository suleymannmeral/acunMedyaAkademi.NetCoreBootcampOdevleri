using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunMedyaWeek4.Abstract
{
    public abstract class Employee
    {
        public abstract double SalaryInfo();
        public void StartStaff(string name)
        {
            Console.WriteLine($"{name} is starting to work ");
        }
    }
}
