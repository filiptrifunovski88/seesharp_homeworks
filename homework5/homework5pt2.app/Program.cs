namespace homework5pt2.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Viktor", 120, 10);
            Manager manager2 = new Manager("Stefan", 200, 30);

            Contractor contractor1 = new Contractor("Filip", 100, 10);
            Contractor contractor2 = new Contractor("Mihail", 150, 13);

            SalePerson salesPerson1 = new SalePerson("Martin", 212, 40);


            Employee[] employees = new Employee[] { manager1, manager2, contractor1, contractor2, salesPerson1 };

            CEO ceo = new CEO("Boban", 10, 5, employees, 100, 150.75);

            ceo.PrintInfo();
            ceo.PrintEmployees();
            manager1.PrintInfo();
            contractor1.PrintInfo();
            salesPerson1.PrintInfo();

        }
    }
}