using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5.app
{
    public class Contractor : Employee
    {
        public Contractor(double workHours, int payPerHour, Manager responsible)
           : base(workHours, payPerHour, responsible)
        {

        }
        public override double GetSalary()
        {
            return WorkHours * PayPerHour;
        }
        public string CurrentPosition()
        {
            return Responsible.Role;
        }
    }
}
