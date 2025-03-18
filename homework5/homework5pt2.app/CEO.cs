namespace homework5pt2.app
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        public double SharesPrice { get; set; }

        public CEO(string name, double workHours, int payPerHour,Employee[] employees, int shares, double sharesPrice)
            : base(name, workHours, payPerHour)
        {
            Role = "CEO";
            Employees = employees;
            Shares = shares;
            SharesPrice = sharesPrice;
        }
        public void AddSharesPrice(double change)
        {
            SharesPrice = change;
        }

        public void PrintEmployees()
        {
            foreach(Employee employee in Employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Role: {employee.Role}, Salary: {employee.GetSalary()}");
            }
        }

        public override double GetSalary()
        {
            return (Shares * SharesPrice) + (WorkHours * PayPerHour);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"CEO Name: {Name}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Salary (Base + Shares): {GetSalary()}");
        }
    }
}
