namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstInput = Console.ReadLine();
            int firstNumber = int.Parse(firstInput);
            Console.WriteLine("First number:" + firstNumber);

            string secondInput = Console.ReadLine();
            int secondNumber = int.Parse(secondInput);
            Console.WriteLine("Second number: " + secondNumber);

            int thirdNumber = default;
            int fourthNumber = default;

            thirdNumber = secondNumber;
            fourthNumber = firstNumber;

            Console.WriteLine("Switched first number: " + thirdNumber);
            Console.WriteLine("Switched second number: " + fourthNumber);
            Console.ReadLine();
        }
    }
}
