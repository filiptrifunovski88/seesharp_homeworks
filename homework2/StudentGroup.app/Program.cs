namespace StudentGroup.app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] studentsG1 = new string[5];
            string[] studentsG2 = new string[5];
            
            for (int i = 0; i < studentsG1.Length; i++)
            {
                Console.Write("Enter name number " + (i + 1) + " for the FIRST array: ");
                studentsG1[i] = Console.ReadLine();
            }

            for (int i = 0; i < studentsG2.Length; i++)
            {
                Console.Write("Enter name number " + (i + 1) + " for the SECOND array: ");
                studentsG2[i] = Console.ReadLine();
            }

            string input = default;
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Enter number between 1 and 22: ");
                input = Console.ReadLine();
                if (input == "1" || input == "2")
                {
                    break;
                }
                Console.WriteLine("Invalid number! Please enter 1 or 2.");
            }

            if (input == "1")
            {
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine("Student in group 1: " + studentsG1[i] + " ");
                }
            }
            else if (input == "2")
            {
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine("Student in group 2: " + studentsG2[i] + " ");
                }
            }
        }
    }
}
