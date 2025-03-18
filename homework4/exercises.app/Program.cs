using exercises.app;

namespace exercisess.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Enter Y to continue or X to colse tab: ");
                string input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    Console.WriteLine("You can continue");
                    Console.Write("Enter number: ");
                    string input1 = Console.ReadLine();

                    if (int.TryParse(input1, out int number))
                    {
                        isValidInput = true;
                        NumberStats(number);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid number.");
                    }
                }
                else if (input == "X")
                {
                    Console.WriteLine("You choose X, you can not continue");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' or 'X'.");
                    continue;
                }
            }

            Console.WriteLine("REGISTER:");
            Console.WriteLine("Please enter your id:");
            string stringRegisterEnteredId = Console.ReadLine();
            int RegisterEnteredId = int.Parse(stringRegisterEnteredId);
            Console.WriteLine("Please enter your username:");
            string registerEnteredUsername = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string registerEnteredPassword = Console.ReadLine();

            User user1 = new User(RegisterEnteredId, registerEnteredUsername, registerEnteredPassword);
            User[] users = new User[] { user1 };
            Console.WriteLine($"You have successfully registered. Your ID: {user1.Id}, Your username: {user1.Username}, Your password: {user1.Password}");

            Console.WriteLine(" ");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine(" ");

            Console.WriteLine("LOGIN: ");
            Console.WriteLine("Please enter your username:");
            string loginEnteredUsername = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string LoginEnteredPassword = Console.ReadLine();

            User foundUser = default;
            foreach (User user in users)
            {
                if (user.Username == loginEnteredUsername && user.Password == LoginEnteredPassword)
                {
                    foundUser = user;
                    break;
                }
            }
            if (foundUser != default)
            {
                Console.WriteLine($"Welcome {foundUser.Username}. Here are your messages:");
                foreach (string message in foundUser.Message)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("Error: Username or password is incorrect.");
            }

            Atm user2 = new Atm("Filip Trifunovski", 123456789, 1234, 100);
            Atm user3 = new Atm("Gjorgi Cvetkov", 987654321, 4321, 60);
            Atm user4 = new Atm("Stefan Petreski", 0192837465, 3333, 361);
            Atm[] users2 = new Atm[] { user2, user3, user4,};

            Console.WriteLine("REGISTER YOUR CARD");
            Console.Write("Enter your full name: ");
            string registerFullNameCard = Console.ReadLine();
            Console.Write("Enter your card number: ");
            string stringRegisterCardNumber = Console.ReadLine();
            int registerCardNumber = int.Parse(stringRegisterCardNumber);
            foreach (Atm user in users2)
            {
                if (user.CardNumber == registerCardNumber)
                {
                    Console.WriteLine("Error: This card number already exists. Registration failed.");
                    return;
                }
            }
            Console.Write("Enter your pin: ");
            string stringRegisterPin = Console.ReadLine();
            int registerPin = int.Parse(stringRegisterPin);
            Console.Write("Enter your balance: ");
            string stringRegisterBalance = Console.ReadLine();
            int registerBalance = int.Parse(stringRegisterBalance);
            Atm user5 = new Atm(registerFullNameCard, registerCardNumber, registerPin, registerBalance);
            Console.WriteLine($"Registration successful for {user5.FullName}. Welcome!");

            Atm[] updatedUsers = new Atm[users2.Length + 1];
            for (int i = 0; i < users2.Length; i++)
            {
                updatedUsers[i] = users2[i];
            }
            updatedUsers[users2.Length] = user5;
            users2 = updatedUsers;


            Console.WriteLine("Enter your card number ( 1234-1234-1234-1234 ): ");
            string stringReadCardNumber = Console.ReadLine();
            string cleanedCardNumber = stringReadCardNumber.Replace("-", "");
            long readCardNumber = long.Parse(cleanedCardNumber);
            Console.WriteLine("Enter your pin:");
            string stringReadPin = Console.ReadLine();
            int readPin = int.Parse(stringReadPin);
            Atm loggedInUser = default;

            foreach (Atm user in users2)
            {
                if (readCardNumber == user.CardNumber && user.CheckPin(readPin))
                {
                    loggedInUser = user;
                    break;
                }
            }

            if (readCardNumber == loggedInUser.CardNumber && loggedInUser.CheckPin(readPin))
            {
                Console.WriteLine(loggedInUser.GreetMessage);
                Console.WriteLine("If you want to check your balance write: B || If you want to withdrawal write: W || If you want to deposition write: D ");
                string input = Console.ReadLine();
                if (input.ToLower() == "b")
                {
                    Console.WriteLine($"Your balance is: {loggedInUser.GetBalance()}$");
                }
                else if (input.ToLower() == "w")
                {
                    Console.WriteLine("How much money do you want to withdrawal?");
                    string input1 = Console.ReadLine();
                    int parsedInput1 = int.Parse(input1);
                    if (parsedInput1 <= loggedInUser.GetBalance())
                    {
                        user2.Withdraw(parsedInput1);
                        Console.WriteLine($"You have withdrawn {parsedInput1}$, now you have {loggedInUser.GetBalance()}$ left.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have {parsedInput1}$ in your balance. Your balance is {loggedInUser.GetBalance()}$");
                    }

                }
                else if (input.ToLower() == "d")
                {
                    Console.WriteLine("How much money do you want to deposit?");
                    string input1 = Console.ReadLine();
                    int parsedInput1 = int.Parse(input1);
                    user2.Deposit(parsedInput1);
                    Console.WriteLine($"You just deposited {parsedInput1}$. Your balance is {loggedInUser.GetBalance()}$");
                }
                else
                {
                    Console.WriteLine("Invalid details, YOU MUST ENTER: || B || W || D ||");
                }
            }
            else
            {
                Console.WriteLine("Invalid credit card!");
            }

        }
        public static void NumberStats(double num)
        {
            if (num > 0)
            {
                if (num % 1 == 0)
                {
                    int intNum = (int)num;
                    if (intNum % 2 == 0)
                    {
                        Console.WriteLine($"Number {num} is positive, even and integer");
                    }
                    else
                    {
                        Console.WriteLine($"Number {num} is positive, odd and integer");
                    }
                }
                else
                {
                    int intNum = (int)num;
                    if (intNum % 2 == 0)
                    {
                        Console.WriteLine($"Number {num} is positive, even decimal");
                    }
                    else
                    {
                        Console.WriteLine($"Number {num} is positive, odd decimal");
                    }
                }
            }
            else if (num < 0)
            {
                if (num % 1 == 0)
                {
                    int intNum = (int)num;
                    if (intNum % 2 == 0)
                    {
                        Console.WriteLine($"Number {num} is negative, even integer");
                    }
                    else
                    {
                        Console.WriteLine($"Number {num} is negative odd integer");
                    }
                }
                else
                {
                    int intNum = (int)num;
                    if (intNum % 2 == 0)
                    {
                        Console.WriteLine($"Number {num} is negative even decimal");
                    }
                    else
                    {
                        Console.WriteLine($"Number {num} is negative odd decimal");
                    }
                }
            }
            else
            {
                Console.WriteLine("Number is zero.");
            }
        }
    }
}