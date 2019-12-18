using System;

namespace String4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Social security number checker and creator
            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface();
                switch (userChoise)
                {
                    // Check input
                    case 'C':
                        SSNChecker();
                        break;
                    // Create a new
                    case 'N':
                        SSNCreator();
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

        static void SSNChecker()
        {
            Console.Write("\nInput social number [DDMMYY-XXXC]: ");
            string userInput = Console.ReadLine();

            userInput = RemoveSpaces(userInput);
            if (IsValidLength(userInput))
            {
                if (IsValidDate(userInput))
                {
                    int idNumber = InputParser(userInput);
                    char getLastChar = GetUserInputChkMark(userInput);
                    bool isOK = IsValidID(idNumber, getLastChar);
                    PrintResult(isOK);
                }
            }
            else
            {
                Console.WriteLine("Check input - too many characters");
            }
        }

        static void SSNCreator()
        {
            Console.Write("\nInput known info [DDMMYY-XXX]: ");
            string userInput = Console.ReadLine();

            userInput = RemoveSpaces(userInput);
            if (IsValidLength(userInput, 10))
            {
                if (IsValidDate(userInput))
                {
                    int idNumber = InputParser(userInput);
                    char getValidationMark = GetValidationMark(idNumber);
                    string sex = GiveSex(userInput);
                    PrintCreatedSSNumber($"{userInput}{getValidationMark} {sex}");
                }
            }
        }

        static char UserInterface()
        {
            Console.WriteLine("Social security number.");
            Console.WriteLine("[C] Validate security number.");
            Console.WriteLine("[N] Create a new one.");
            Console.WriteLine("[X] Close the program.");
            Console.Write("Choose prodecure: ");

            return char.ToUpper(Console.ReadKey().KeyChar);
        }


        static bool IsValidDate(string userInput)
        {
            bool result = false;
            string day = userInput.Substring(0, 2);
            string month = userInput.Substring(2, 2);
            string year = userInput.Substring(4, 2);
            string century = userInput.Substring(6, 1);

            if (century == "-")
            {
                year = "19" + year;
            }
            else if (century.ToUpper() == "A")
            {
                year = "20" + year;
            }
            else
            {
                Console.WriteLine("Wrong century.");
                return result;
            }

            try
            {
                DateTime birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return result;
        }

        /// <summary>
        /// Check is userInput correct length.
        /// Default Length is 11. Return true or false.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        static bool IsValidLength(string userInput)
        {
            return userInput.Length == 11;

            //if (userInput.Length == 11)
            //    return true;
            //else
            //    return false;

        }

        /// <summary>
        /// Check is userInput correct length.
        /// Varialble length is correct Length. Return true or false.
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        static bool IsValidLength(string userInput, int length)
        {
            return userInput.Length == length;
        }

        static string RemoveSpaces(string userInput)
        {
            string result = userInput.Replace(" ", "");
            return result;
        }

        static char GetUserInputChkMark(string userInput)
        {
            return userInput[userInput.Length - 1];
        }


        static int InputParser(string stringParser)
        {
            string removed = stringParser;
            if (stringParser.Length > 10)
            {
                removed = stringParser.Remove(10, 1);
            }
            removed = removed.Remove(6, 1);

            return int.Parse(removed);
        }

        static bool IsValidID(int idNumber, char userInputChkMark)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            int modChecker = idNumber % 31;

            if (checkMark[modChecker] == userInputChkMark)
                return true;
            else
                return false;
        }

        static char GetValidationMark(int idNumber)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int modChecker = idNumber % 31;

            return checkMark[modChecker];
        }

        static string GiveSex(string input)
        {
            input = input.Substring(7);
            int sexNum = int.Parse(input);
            string sex;
            if (sexNum % 2 == 0)
            {
                sex = "female";
            }
            else
            {
                sex = "male";
            }
            return sex;
        }

        static void PrintResult(bool isValidId)
        {
            if (isValidId)
                Console.WriteLine("Correct security number!");
            else
                Console.WriteLine("Incorrect security number!");
        }

        static void PrintCreatedSSNumber(string newSSNumber)
        {
            Console.WriteLine($"Created security number: {newSSNumber}");
        }
    }
}
