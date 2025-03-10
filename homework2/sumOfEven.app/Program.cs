using System;

namespace sumOfEven.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sixNumberArr = new int[6];
            int sum = 0;

            for(int i = 0; i < sixNumberArr.Length; i++)
            {
                Console.Write("Enter " + (i + 1) + " number in the array: ");
                sixNumberArr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < sixNumberArr.Length; i++)
            {
                if (sixNumberArr[i] % 2 == 0)
                {
                    sum += sixNumberArr[i];
                }
            }
            Console.WriteLine("The sum of even numbers is: " + sum);
        }
    }
}
