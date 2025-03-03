namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            double firstNumber = double.Parse(firstInput);
            Console.WriteLine("First number: " + firstNumber);

            string secondInput = Console.ReadLine();
            double secondNumber = double.Parse(secondInput);
            Console.WriteLine("Second number: " + secondNumber);

            string thirdInput = Console.ReadLine();
            double thirdNumber = double.Parse(thirdInput);
            Console.WriteLine("Third number: " + thirdNumber);

            string fourthInput = Console.ReadLine();
            double fourthNumber = double.Parse(fourthInput);
            Console.WriteLine("Fourth number: " + fourthNumber);

            double allNumbers = firstNumber + secondNumber + thirdNumber + fourthNumber;

            Console.WriteLine("Average Number is: " + allNumbers / 4);
            Console.ReadLine();
        }
    }
}
