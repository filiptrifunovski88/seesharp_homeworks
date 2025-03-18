namespace homework5pt2.app
{
    public class Manager : Employee
    {
        public Manager(string name, double workHours, int payPerHour)
                   : base(name, workHours, payPerHour)
        {
            Role = "Manager";
        }
    }
}
