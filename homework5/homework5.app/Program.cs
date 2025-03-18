namespace homework5.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Director");

            Contractor contractor = new Contractor(160, 20, manager);

            Console.WriteLine($"Contractor Salary: {contractor.GetSalary()}");
            Console.WriteLine($"Contractor's Current Position: {contractor.CurrentPosition()}");
        }
    }
}
