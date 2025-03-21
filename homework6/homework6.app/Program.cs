namespace homework6.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> listOfNumbers = new Queue<int>();

            while(true)
            {
                Console.WriteLine("Enter number: ");
                string input = Console.ReadLine();

                if(int.TryParse(input, out int convertedInput))
                {
                    listOfNumbers.Enqueue(convertedInput);
                }
                else
                {
                    Console.WriteLine("Enter valid number!");
                    continue;
                }

                Console.WriteLine("If you want to add more numbers write ( Y - yes ) or ( N - no )");
                string input2 = Console.ReadLine().ToUpper();

                if(input2 != "Y")
                {
                    break;
                }
            }

            Console.WriteLine("Number/s you entered: ");
            foreach(int number in listOfNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
