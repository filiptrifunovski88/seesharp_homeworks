namespace homework5pt2.app
{
    public class Contractor : Employee
    {
        public Contractor(string name, double workHours, int payPerHour)
            :base (name, workHours, payPerHour)
        {
            Role = "Contractor";
        }
    }
}
