using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5.app
{
    public class Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Employee(double workHours, int payPerHour, Manager responsible)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public virtual double GetSalary()
        {
            return WorkHours * PayPerHour;
        }
    }
}
