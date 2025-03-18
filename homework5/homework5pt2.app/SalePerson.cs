namespace homework5pt2.app
{
    public class SalePerson : Employee
    {
        public SalePerson(string name, double workHours, int payPerHour)
            : base(name, workHours, payPerHour)
        {
            Role = "Sale Person";
        }
    }
}
