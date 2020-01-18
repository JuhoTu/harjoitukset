using System;

namespace ReferenceNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks inputted reference number or creates new ones
            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface();
                switch (userChoise)
                {
                    // Check input
                    case 'C':
                        RefChecker();
                        break;
                    // Create a new one
                    case 'N':
                        RefCreator();
                        break;
                    // Create multiple new ones
                    case 'M':
                        RefMultiCreator();
                        break;
                    // Exit
                    case 'X':
                        break;

                    default:
                        Console.WriteLine("\nCheck input. Proceed by pressing Enter.");
                        Console.ReadLine();
                        break;
                }
                Console.ReadLine();
            } while (userChoise != 'X');
        }

        static char UserInterface()
        {
            Console.WriteLine("Reference number validator and creator.");
            Console.WriteLine("[C] Validate reference number.");
            Console.WriteLine("[N] Create a new one.");
            Console.WriteLine("[M] Create multiple.");
            Console.WriteLine("[X] Close the program.");
            Console.Write("Choose procedure: ");

            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static void RefChecker()
        {
            string input = Inputter();
            if (Validator(input) == true)
            {
                Console.WriteLine("Reference number is valid.");
            }
            else
            {
                Console.WriteLine("Reference number is invalid.");
            }
        }

        static void RefCreator()
        {
            string create = RefCreate();
        }

        static void RefMultiCreator()
        {
            int count = HowMany();
            for (int i = 0; i < count; i++)
            {
                string create = RefCreate();
                Vault(create);
            }
        }

        static string Inputter()
        {
            Console.Write("\nInput the reference number: ");
            string input = "";
            bool correctForm = false;
            do
            {
                input = Console.ReadLine();
                RemoveExtra(ref input);
                if (IsNumbersOnly(input) == true)
                {
                    if (Validator(input) == true)
                        correctForm = true;
                }
                else if (input == "x")
                    break;
                else
                    Error(2);
            } while (correctForm == false);
            
            Console.WriteLine(input);
            return input;
        }

        static void RemoveExtra(ref string userInput)
        {
            userInput = userInput.Replace(" ", "");
        }

        static bool IsNumbersOnly(string userInput)
        {
            int failCount = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                bool tryParse = int.TryParse(userInput[i].ToString(), out _);
                if (tryParse == false)  
                    failCount++;
            }
            if (failCount == 0)
                return true;
            else
                return false;
        }

        static bool Validator(string checkInput)
        {
            if (checkInput.Length > 3 && checkInput.Length < 20)
            {
                if (CheckNumber(checkInput, 1) == true)
                    return true;
            }
            else
                Error(3);
            return false;
        }

        static bool CheckNumber(string input, int caller)
        {
            string refNumber = input;
            int[] multiplier = { 7, 3, 1 };
            int checkNumber = 0, correctCheckNumber, product = 1, sum = 0, nearestTenth;
            if (caller == 1)
            {
                refNumber = refNumber.Remove(input.Length - 1);
                checkNumber = int.Parse(input[input.Length - 1].ToString());
            }
            for (int i = refNumber.Length - 1; i >= 0; i--)
            {
                if (product == 1)
                {
                    product = int.Parse(refNumber[i].ToString()) * multiplier[0];
                    sum += product;
                    Console.WriteLine(sum);
                    product = 7;
                }
                else if (product == 7)
                {
                    product = int.Parse(refNumber[i].ToString()) * multiplier[1];
                    sum += product;
                    Console.WriteLine(sum);
                    product = 3;
                }
                else if (product == 3)
                {
                    product = int.Parse(refNumber[i].ToString()) * multiplier[2];
                    sum += product;
                    Console.WriteLine(sum);
                    product = 1;
                }
            }
            nearestTenth = Round(sum);
            correctCheckNumber = nearestTenth - sum;
            if (caller == 1)
            {
                if (checkNumber == correctCheckNumber)
                {
                    Console.WriteLine("Check number check ok");
                    Console.WriteLine($"{checkNumber}, {correctCheckNumber}");
                    return true;
                }
                else
                    Console.WriteLine("Check number check failed");
            }
            Console.WriteLine($"{checkNumber}, {correctCheckNumber}");
            return false;
        }

        static int Round(int sum)
        {
            return (int)((Math.Round(sum / 10.0)) * 10);
        }

        static string RefCreate()
        {
            return "0";
        }

        static int HowMany()
        {
            return 0;
        }

        static void Vault(string input)
        {

        }

        static void Error(int errorCode)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            switch (errorCode)
            {
                case 1:
                    Console.WriteLine("Error occurred!");
                    break;
                case 2:
                    Console.WriteLine("Input must contain only numbers!");
                    break;
                case 3:
                    Console.WriteLine("Input should have 4 - 20 numbers!");
                    break;
            }
            Console.ResetColor();
        }
    }
}
