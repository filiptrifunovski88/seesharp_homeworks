using System;

namespace homework1bonus.app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            // Task 1:
            // Write a program that will print out all numbers from the range 1-N (N is input from keyboard, N>2) that divide with 3.
            Console.Write("Enter first input: ");
            string input1 = Console.ReadLine();
            int input1parse = int.Parse(input1);

            Console.Write("Enter second input: ");
            string input2 = Console.ReadLine();
            int input2parse = int.Parse(input2);

            if (input1parse % 3 == 0 || input2parse % 3 == 0)
            {
                if (input1parse % 3 == 0)
                {
                    Console.WriteLine($"First number {input1parse} is divisible by 3");
                }
                else if (input2parse % 3 == 0)
                {
                    Console.WriteLine($"Second number {input2parse} is divisible by 3");
                }
            }
            else
            {
                Console.WriteLine("The numbers are not divisible by 3");
            }


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            //// Task 2:
            //// Write a program that will print out all numbers in the range 1-N (N is input from keyboard, N>5) that divide 2 and 3.
            Console.Write("Enter first input: ");
            string input3 = Console.ReadLine();
            int input3parse = int.Parse(input3);

            Console.Write("Enter second input: ");
            string input4 = Console.ReadLine();
            int input4parse = int.Parse(input4);

            if ((input3parse % 2 == 0 || input3parse % 3 == 0) || (input4parse % 2 == 0 || input4parse % 3 == 0))
            {

                if (input3parse % 2 == 0 || input3parse % 3 == 0)
                {
                    Console.WriteLine($"First number {input3parse} is divisible by 2 or 3");
                }

                if (input4parse % 2 == 0 || input4parse % 3 == 0)
                {
                    Console.WriteLine($"Second number {input4parse} is divisible by 2 or 3");
                }
            }
            else
            {
                Console.WriteLine("Neither of the numbers are divisible by 2 or 3");
            }


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            //// Task 3:
            //// Write a program, which will be calculating the product of the digits of an input number.
            Console.Write("Enter a number: ");
            string input5 = Console.ReadLine();
            int product = 1;

            foreach (char digit in input5)
            {
                int digitInt = int.Parse(digit.ToString());
                product *= digitInt;
            }
            Console.WriteLine($"The product of the digits is: {product}");


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            //// Task 4:
            //// Write a program that will find out the sum of all even numbers in the range 1-N (N is input from keyboard).
            Console.Write("Enter number: ");
            string input6 = Console.ReadLine();
            int input6parse = int.Parse(input6);
            for (int i = 1; i <= input6parse; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"From 1 to {input6} even number is: {i}");
                }
            }


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            //// Task 5:
            //// Write a program that will find out the sum of all odd numbers in the range 1-N (N is input from keyboard).
            Console.Write("Enter number: ");
            string input7 = Console.ReadLine();
            int input7parse = int.Parse(input7);
            for (int i = 1; i <= input7parse; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"From 1 to {input7} odd number is: {i}");
                }
            }


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            //// Task 6:
            //// Write a program that will find out the sum of all numbers that divide 5 in the range 1-N (N is input from keyboard).
            Console.Write("Enter number: ");
            string input8 = Console.ReadLine();
            int input8parse = int.Parse(input8);
            int sum = 0;
            for (int i = 0; i <= input8parse; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum is: {sum}");

            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            //// Task 7:
            //// Write a program that will reverse the array {“a”,”b”,”c”,”d”} so that the output is {“d”,“c”,“b”,“a”}. - Do NOT use reverse array method :)
            string[] arr1 = { "a", "b", "c", "d" };
            Console.WriteLine("Original array: " + string.Join(", ", arr1));
            string[] arr2 = { arr1[3], arr1[2], arr1[1], arr1[0] };
            Console.WriteLine("reverse array: " + string.Join(", ", arr2));


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            // Task 8:
            // Write a program that will read two arrays from console input. Then the program has to make a comparison of the arrays and determine whether they are equal or not. { 1, 2, 3, 4 } == { 1, 2, 3, 4 } { 1, 2, 3, 4 } != { 2, 1, 3, 4 }
            bool isValidInput2 = false;
            string[] arr3 = default;
            while (!isValidInput2)
            {
                Console.Write("Enter the first array (Filip Mihail Ivana... USE ( space )): ");
                string input9 = Console.ReadLine();
                arr3 = input9.Split(' ', StringSplitOptions.RemoveEmptyEntries);


                if (arr3.Length > 1)
                {
                    isValidInput2 = true;
                    Console.WriteLine("First array: ");
                    foreach (string item in arr3)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Enter the array with ( space )");
                }
            }

            bool isValidInput3 = false;
            string[] arr4 = default;
            while (!isValidInput3)
            {
                Console.Write("Enter the second array (Filip Mihail Ivana... USE ( space )): ");
                string input10 = Console.ReadLine();
                arr4 = input10.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (arr4.Length > 1)
                {
                    isValidInput3 = true;
                    Console.WriteLine("Second array: ");
                    foreach (string item in arr4)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Enter the array with ( space )");
                }
            }

            if (arr3.Length != arr4.Length)
            {
                Console.WriteLine("Arrays are not identical.");
            }
            else
            {
                bool arraysAreEqual = true;

                for (int i = 0; i < arr3.Length; i++)
                {
                    if (arr3[i] != arr4[i])
                    {
                        arraysAreEqual = false;
                        break;
                    }
                }

                if (arraysAreEqual)
                {
                    Console.WriteLine("Arrays are identical.");
                }
                else
                {
                    Console.WriteLine("Arrays are not identical.");
                }
            }


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            //Task 9:
            // Write a program that will find all numbers in between 1 and 1000, that divide the sum composed of their digits.
            for (int i = 1; i <= 1000; i++)
            {
                string digits = "";
                int sumOfDigits = 0;
                bool isValied3 = false;

                foreach (char digit in i.ToString())
                {
                    digits += digit + " ";
                    int digitInt = digit - '0'; // Ова го видов од на интернет пошо неможев да го решам или да најдам друго решение ( дека - '0' од Char го претвора во Int според некој ASCII код.)
                    sumOfDigits += digitInt;
                }
                if (i % sumOfDigits == 0)
                {
                    isValied3 = true;
                }
                Console.WriteLine($"Number: {i}, Digits: {digits}, Sum of digits: {sumOfDigits}, Number {i} can dividе with {sumOfDigits} {isValied3}");
            }


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            // Task 10:
            // Write a program that will find out all numbers in the range [1 : 1000] that divide the product composed of their digits.
            for (int i = 1; i <= 1000; i++)
            {
                string digits1 = "";
                int productOfDigits = 1;
                bool isValied4 = false;

                foreach (char digit in i.ToString())
                {
                    digits1 += digit + " ";
                    int digitInt = digit - '0';
                    productOfDigits *= digitInt;
                }
                if (productOfDigits != 0 && i % productOfDigits == 0)
                {
                    isValied4 = true;
                }
                Console.WriteLine($"Number: {i}, Digits: {digits1}, Product of digits: {productOfDigits}, Number {i} can divide with {productOfDigits} {isValied4}");
            }


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            // Task 11:
            // Write a program that will print out all two-digit numbers, which have the first digit greater than the second digit.
            for (int i = 10; i <= 99; i++)
            {

                int firstDigit = i / 10;
                int secondDigit = i % 10;
                if (firstDigit > secondDigit)
                {
                    Console.WriteLine(i);
                }
            }


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            // Task 12:
            // Write a short program that prints each number from 1 to 100 on a new line. For each number that is divided by 3 print “Fizz” instead of the number. For each number that is divided by 5 print “Buzz” instead of the number. For each number that is divided by 3 and 5 print “FizzBuzz” instead of the number.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else
                {
                    Console.WriteLine($"{i} can not devide with 3 or 5");
                }
            }


            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////


            // BONUS
            bool isValiedInput5 = false;

            while(!isValiedInput5)
            {
                Console.Write("Enter difficulty of the game! ( EASY, NORMAL, HARD ): ");
                string difficultyOfTheGame = Console.ReadLine();

                if(difficultyOfTheGame.ToLower() == "easy")
                {
                    isValiedInput5 = true;
                    int lives = 8;
                    Random random = new Random();
                    int myNumber = random.Next(1, 101);

                    while(lives > 0)
                    {
                        Console.Write("Guess the number form 1 to 100, difficulty EASY: ");
                        string guessedNumber = Console.ReadLine();
                        int parsedGuessedNumber;

                        bool isValidNumber = int.TryParse(guessedNumber, out parsedGuessedNumber);

                        if(!isValidNumber)
                        {
                            Console.WriteLine("Please enter a valid number.");
                            continue;
                        }
                        if(parsedGuessedNumber > 100)
                        {
                            Console.WriteLine("Please enter a number from 1 to 100.");
                            continue;
                        }


                        if (parsedGuessedNumber == myNumber)
                        {
                            Console.WriteLine($"Nailed it. YOU WON! Number entered: {parsedGuessedNumber}");
                            break;
                        }
                        else if (parsedGuessedNumber > myNumber)
                            {
                            if(parsedGuessedNumber - myNumber > 3)
                            {
                                Console.WriteLine($"Your guess is far to high, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                            else
                            {
                                Console.WriteLine($"Your guess is a little bit higher, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                            }
                        else
                        {
                            if (myNumber - parsedGuessedNumber > 3)
                            {
                                Console.WriteLine($"Your guess is far too low, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                            else
                            {
                                Console.WriteLine($"Your guess is a little bit lower, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                        }
                        lives--;
                        if (lives == 0)
                        {
                            Console.WriteLine("Game Over! You've run out of lives.");
                        }
                    }

                }
                else if (difficultyOfTheGame.ToLower() == "normal")
                {
                    isValiedInput5 = true;
                    int lives = 6;
                    Random random = new Random();
                    int myNumber = random.Next(1, 501);

                    while (lives > 0)
                    {
                        Console.Write("Guess the number form 1 to 500, difficulty NORMAL: ");
                        string guessedNumber = Console.ReadLine();
                        int parsedGuessedNumber;

                        bool isValidNumber = int.TryParse(guessedNumber, out parsedGuessedNumber);

                        if (!isValidNumber)
                        {
                            Console.WriteLine("Please enter a valid number.");
                            continue;
                        }
                        if (parsedGuessedNumber > 500)
                        {
                            Console.WriteLine("Please enter a number from 1 to 500.");
                            continue;
                        }


                        if (parsedGuessedNumber == myNumber)
                        {
                            Console.WriteLine($"Nailed it. YOU WON! Number entered: {parsedGuessedNumber}");
                            break;
                        }
                        else if (parsedGuessedNumber > myNumber)
                        {
                            if (parsedGuessedNumber - myNumber > 3)
                            {
                                Console.WriteLine($"Your guess is far to high, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                            else
                            {
                                Console.WriteLine($"Your guess is a little bit higher, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                        }
                        else
                        {
                            if (myNumber - parsedGuessedNumber > 3)
                            {
                                Console.WriteLine($"Your guess is far too low, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                            else
                            {
                                Console.WriteLine($"Your guess is a little bit lower, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                        }
                        lives--;
                        if (lives == 0)
                        {
                            Console.WriteLine("Game Over! You've run out of lives.");
                        }
                    }
                }
                else if (difficultyOfTheGame.ToLower() == "hard")
                {
                    isValiedInput5 = true;
                    int lives = 4;
                    Random random = new Random();
                    int myNumber = random.Next(1, 1001);

                    while (lives > 0)
                    {
                        Console.Write("Guess the number form 1 to 1000, difficulty HARD ");
                        string guessedNumber = Console.ReadLine();
                        int parsedGuessedNumber;

                        bool isValidNumber = int.TryParse(guessedNumber, out parsedGuessedNumber);

                        if (!isValidNumber)
                        {
                            Console.WriteLine("Please enter a valid number.");
                            continue;
                        }
                        if (parsedGuessedNumber > 1000)
                        {
                            Console.WriteLine("Please enter a number from 1 to 1000.");
                            continue;
                        }


                        if (parsedGuessedNumber == myNumber)
                        {
                            Console.WriteLine($"Nailed it. YOU WON! Number entered: {parsedGuessedNumber}");
                            break;
                        }
                        else if (parsedGuessedNumber > myNumber)
                        {
                            if (parsedGuessedNumber - myNumber > 3)
                            {
                                Console.WriteLine($"Your guess is far to high, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                            else
                            {
                                Console.WriteLine($"Your guess is a little bit higher, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                        }
                        else
                        {
                            if (myNumber - parsedGuessedNumber > 3)
                            {
                                Console.WriteLine($"Your guess is far too low, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                            else
                            {
                                Console.WriteLine($"Your guess is a little bit lower, number entered: {parsedGuessedNumber}, Lives: {lives}, Try again!");
                            }
                        }
                        lives--;
                        if (lives == 0)
                        {
                            Console.WriteLine("Game Over! You've run out of lives.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Incorect inpiut!");
                }
            }
        }
    }
}
