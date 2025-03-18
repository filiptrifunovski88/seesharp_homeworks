namespace homework5pt2.app
{
    public class Employee
    {
        public string Name { get; set; }
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public string Role { get; set; }

        public Employee(string name, double workHours, int payPerHour)
        {
            Name = name;
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Role = "Employee";
        }

        public virtual double GetSalary()
        {
            return WorkHours * PayPerHour;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Role: {Role}, Salary: {GetSalary()}");
        }
    }
}