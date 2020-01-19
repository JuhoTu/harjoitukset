using System;
using System.IO;

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
                    case 'C': // Check input
                        RefChecker();
                        break;
                    case 'N': // Create a new one
                        RefCreator();
                        break;
                    case 'M': // Create multiple new ones
                        RefMultiCreator();
                        break;
                    case 'X': // Exit
                        break;
                    default: // In other cases
                        Error(1, null);
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

        /// <summary>
        /// This is the main method for reference number check, caller index is 0
        /// </summary>
        static void RefChecker()
        {
            string input = "";
            input = Inputter(ref input, 21, 0, true); // Asks input
            if (Validator(input, 21, true) == true) // Validates input
                Console.WriteLine("Reference number is valid.");
            else
                Console.WriteLine("Reference number is invalid.");
        }

        /// <summary>
        /// This is the main method for reference number creation, caller index is 1
        /// </summary>
        static void RefCreator()
        {
            string basePart = BasePart(1, 20); // Stores user's given info of basepart
            if (basePart.ToUpper() != "X")
            {
                string created = RefCreate(basePart); // Creates a full ref number
                Console.WriteLine($"Created reference number: {Print(created)}");
            }
            else
                Console.WriteLine("Reference number creation was cancelled.");
        }

        /// <summary>
        /// This is the main method for multiple reference number creation, caller index is 2
        /// </summary>
        static void RefMultiCreator()
        {
            int count = HowMany(); // Asks user of how many new
            string countNum = count.ToString(), basePart, filePath = @"referencenumber.txt";
            int max = 19 - countNum.Length; // Makes ref number max length to be able to be 20 at max
            if (count > 0) // Runs only when more than zero will be created
            {
                basePart = BasePart(2, max); // Stores user's given info of basepart
                if (basePart.ToUpper() != "X")
                {
                    Console.Write("Name for reference numbers: "); // Asks name for ref num, could be f.ex. customer name
                    Vault(Console.ReadLine(), filePath); // Stores the given name to file
                    for (int i = 0; i < count; i++) // Creates a new number each loop from basepart and ref num index
                    {
                        string created = RefCreate(BaseMulti(basePart, i + 1)); // Creates a new num with multi creation options
                        Vault(Print(created), filePath); // Stores created to a file
                    }
                    Console.WriteLine($"Created reference numbers have been saved to a file at {filePath}.");
                }
                else
                    Console.WriteLine("Creation was cancelled.");
            }
            else
                Console.WriteLine("Creation was cancelled.");
        }

        /// <summary>
        /// When input is needed, this function will check its suitability, caller index 3
        /// </summary>
        /// <param name="input"></param>
        /// <param name="max"></param>
        /// <param name="caller"></param>
        /// <param name="validate"></param>
        /// <returns></returns>
        static string Inputter(ref string input, int max, int caller, bool validate)
        {
            Console.WriteLine();
            bool correctForm = false;
            do
            {
                if (caller == 0) // Asks reference number on check
                {
                    Console.Write("Input the reference number: ");
                    input = Console.ReadLine();
                }
                if (caller == 1 || caller == 2) // Asks basepart on creation
                {
                    Console.Write("Input the basepart: ");
                    input = Console.ReadLine();
                }
                if (input.ToUpper() == "X")
                    break; // Stops the operation
                if (NoZeroStart(input) == true) // Checks that input will not start with zero
                {
                    RemoveExtra(ref input, 3); // Removes spaces
                    if (IsNumbersOnly(input) == true) // Checks that only contains numbers
                    {
                        if (Validator(input, max, validate) == true)
                            correctForm = true; // If validation is valid continue forward
                    }
                    else
                        Error(2, "X"); // If checks fail
                }
                else
                    Error(6, null); // If checks fail
            } while (correctForm == false);
            return input;
        }

        /// <summary>
        /// Reference numbers should not start with zero so, this will check that
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static bool NoZeroStart(string input)
        {
            bool noZero = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() != "0") // Checks that the first number is not zero
                    noZero = true;
                else // If check fails
                    break;
            }
            return noZero;
        }

        /// <summary>
        /// Had there been accidental spaces on number this will remove them from input
        /// </summary>
        /// <param name="userInput"></param>
        static void RemoveExtra(ref string input, int caller)
        {
            if (caller == 3)
                input = input.Replace(" ", ""); // Removes spaces
            if (caller == 4)
            {
                input = input.Replace(".", ""); // Remove dots
                input = input.TrimStart(); // Remove spaces from start
            }
        }

        /// <summary>
        /// Checks that input only contains numbers
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        static bool IsNumbersOnly(string userInput)
        {
            int failCount = 0;
            for (int i = 0; i < userInput.Length; i++)
            { // Trys parse for all index of string as 20 numbers can be too long for int to handle
                bool tryParse = int.TryParse(userInput[i].ToString(), out _);
                if (tryParse == false) // In case input cannot be parsed input contains other than numbers too
                    failCount++;
            }
            if (failCount == 0) // If the input only contains numbers this returns true
                return true;
            else
                return false;
        }

        /// <summary>
        /// Checks that the input is valid
        /// </summary>
        /// <param name="checkInput"></param>
        /// <param name="max"></param>
        /// <param name="validate"></param>
        /// <returns></returns>
        static bool Validator(string checkInput, int max, bool validate)
        {
            if (checkInput.Length > 3 && checkInput.Length < max)
            { // Checks length
                if (validate == false) // In case of creation, no validation is needed
                    return true;
                else
                {
                    int i = 0; // Ref part is only for creation
                    if (CheckNumber(checkInput, 0, ref i) == true) // Checks that check number is correct
                        return true;
                    else
                        Error(5, "X"); // If check fails
                }
            }
            else
                Error(3, null); // If check fails
            return false;
        }

        /// <summary>
        /// Creates a check number based on basepart or checks if inputted reference number contains a valid check number.
        /// Pretty sure this should just be hash not checkNumber
        /// </summary>
        /// <param name="input"></param>
        /// <param name="caller"></param>
        /// <param name="checkNumber"></param>
        /// <returns></returns>
        static bool CheckNumber(string input, int caller, ref int checkNumber)
        {
            string refNumber = input;
            int[] multiplier = { 7, 3, 1 };
            int correctCheckNumber, product = 1, sum = 0;
            if (caller == 0)
            { // If input comes from check ref num, will remove last number and store it to checkNumber
                refNumber = refNumber.Remove(input.Length - 1);
                checkNumber = int.Parse(input[^1].ToString());
            }
            for (int i = refNumber.Length - 1; i >= 0; i--)
            { // Multiplies certain index with correct multiplier from right to left
                if (product == 1)
                {
                    product = int.Parse(refNumber[i].ToString()) * multiplier[0]; // Parses refnum index and multiplies it
                    sum += product; // Adds product to sum
                    product = 7; // Sets product to new default
                }
                else if (product == 7)
                {
                    product = int.Parse(refNumber[i].ToString()) * multiplier[1];
                    sum += product;
                    product = 3;
                }
                else if (product == 3)
                {
                    product = int.Parse(refNumber[i].ToString()) * multiplier[2];
                    sum += product;
                    product = 1;
                }
            }
            int nearestTenth = Round(sum); // Rounds sum and stores it
            correctCheckNumber = nearestTenth - sum; // Subtracks the sum from nearest tenth and that is the correct hash
            if (caller == 0)
            { // In case input comes from ref checker checks that hashes match
                if (checkNumber == correctCheckNumber)
                    return true;
            }
            if (caller == 1 || caller == 2) // In creation saves hash
                checkNumber = correctCheckNumber;
            return false;
        }

        /// <summary>
        /// Rounds up the input to nearest tenth
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        static int Round(int sum)
        {
            return (int)(Math.Ceiling(sum / 10.0d) * 10); // Rounds given number to upper tenth
        }

        /// <summary>
        /// On number creation, asks user to input the base part such as customer number
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static string BasePart(int caller, int max)
        {
            string userInput = "";
            string basePart = Inputter(ref userInput, max, caller, false); // Asks basepart
            return basePart;
        }

        /// <summary>
        /// Runs necessary operations for reference number creation
        /// </summary>
        /// <param name="basePart"></param>
        /// <returns></returns>
        static string RefCreate(string basePart)
        {
            int checkNumber = 0;
            if (basePart.ToUpper() != "X")
                CheckNumber(basePart, 1, ref checkNumber); // Creates hash
            basePart += checkNumber; // Adds hash to basepart
            return basePart; // Returns created ref number
        }

        /// <summary>
        /// Asks the user in multiple creation of how many new numbers they are wanting to create
        /// </summary>
        /// <returns></returns>
        static int HowMany()
        {
            int howMany = 1, max = 1000; // Defines max amount of entries
            bool okInput = false;
            do
            {
                Console.Write("\nHow many numbers will be created? ");
                string input = Console.ReadLine(); // Stores input
                bool tryParse = int.TryParse(input, out _); // Stores tryparse result
                if (tryParse == true)
                { // In case parse can be done input contains only numbers and is acceptable
                    if (int.Parse(input) < max)
                    { // Checks that input is lower than max allowed number
                        howMany = int.Parse(input); // Stores input to howMany
                        okInput = true; // To get out of do
                    }
                    else
                        Error(4, max.ToString()); // In case of fail
                }
                else
                    Error(2, "0"); // In case of fail
            } while (okInput == false);
            return howMany;
        }

        /// <summary>
        /// Adds a number to basepart based on loop number
        /// </summary>
        /// <param name="basePart"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        static string BaseMulti(string basePart, int i)
        {
            basePart += i; // Adds an extra number to ref num based on loop number
            return basePart;
        }

        /// <summary>
        /// Stores created numbers to a text file
        /// </summary>
        /// <param name="input"></param>
        /// <param name="filePath"></param>
        static void Vault(string input, string filePath)
        {
            using StreamWriter vaulter = new StreamWriter(filePath, true); // Creates vaulter for file writing with inbound filepath
            vaulter.WriteLine(input); // Adds a new line to file
        }

        /// <summary>
        /// Edits the reference number to be in groups of five chars, caller index 4
        /// </summary>
        /// <param name="input"></param>
        static string Print(string input)
        {
            int count = input.Length; // Store input length
            for (int i = 20; i > count; i--) // Add dots so that input length is 20
                input = input.Insert(0, ".");
            count = input.Length; // Store input length
            for (int i = count -1; i > 0; i--)
            {
                if (i % 5 == 0) // If number in question is fifth char, add space
                    input = input.Insert(i, " ");
            }
            RemoveExtra(ref input, 4); // Removes unneeded chars
            return input;
        }

        /// <summary>
        /// Error codes and messages
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="msg"></param>
        static void Error(int errorCode, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Changes console color to red to better the error look
            switch (errorCode)
            { // Errors based on code. Some need a message input
                case 1:
                    Console.WriteLine($"\nCheck input. Proceed by pressing Enter.");
                    break;
                case 2:
                    Console.WriteLine($"Input must contain only numbers! Typing {msg} and pressing enter will stop.");
                    break;
                case 3:
                    Console.WriteLine($"Invalid amount of numbers!");
                    break;
                case 4:
                    Console.WriteLine($"Maximum of {msg} reference numbers can be created at a time.");
                    break;
                case 5:
                    Console.WriteLine($"Check number is invalid! Typing {msg} and pressing enter will stop.");
                    break;
                case 6:
                    Console.WriteLine($"Reference number can't start with zeros!");
                    break;
                default: // Default case
                    Console.WriteLine("\nError occured!");
                    break;
            }
            Console.ResetColor(); // Changes console color to normal
        }
    }
}