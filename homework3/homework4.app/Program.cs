namespace homework4.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime input = DateTime.MinValue;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Enter your birthdate (yyyy-MM-dd): ");
                string birthDay = Console.ReadLine();

                if (DateTime.TryParse(birthDay, out input))
                {
                    isValidInput = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid date format");
                }
            }
            AgeCalculator(input);
        }
        public static void AgeCalculator(DateTime birthDay)
        {
            DateTime today = DateTime.Today;
            int ageNow = today.Year - birthDay.Year;
            Console.WriteLine($"You age now are: {ageNow}");
            Console.WriteLine($"Today: {today}");
            DateTime threeDaysFromNow = today.AddDays(3);
            Console.WriteLine($"Three days from now: {threeDaysFromNow}");
            DateTime oneMonthFromNow = today.AddMonths(1);
            Console.WriteLine($"One month from now: {oneMonthFromNow}");
            DateTime oneMonthFromNowAndThreeDaysFromNow = today.AddMonths(1).AddDays(3);
            Console.WriteLine($"One month and three days from now: {oneMonthFromNowAndThreeDaysFromNow}");
            DateTime oneYearAndTwoMonthsAgoFromNow = today.AddYears(-1).AddMonths(-2);
            Console.WriteLine($"One year and two months from now: {oneYearAndTwoMonthsAgoFromNow}");
            int currentMonthOfToday = DateTime.Now.Month;
            Console.WriteLine($"Current month of Today: {currentMonthOfToday}");
            int currentYearOfToday = DateTime.Now.Year;
            Console.WriteLine($"Current year of Today: {currentYearOfToday}");
        }
    }
}
