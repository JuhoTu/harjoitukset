using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("Give a number of how many stars you'd like to see: ");
            int input = Parse();
            if (input > 1)
            {
                Star(input);
            }
            else if (input == 0)
            {
                Console.WriteLine(":(");
            }
            else
            {
                Console.WriteLine("Error! Give a valid number!");
            }

            //taks2
            Console.WriteLine("\n\nGive two numbers: ");
            int in1 = Parse();
            int in2 = Parse();
            Minimi(in1, in2);

            //task 3
            int retNumber, lowerBound = 0, upperBound = 100;
            Console.WriteLine($"\n\nGive number within range {lowerBound} - {upperBound}");
            retNumber = numberFromRange(lowerBound, upperBound);
            Console.WriteLine(retNumber);

            //task 4
            Console.WriteLine("\nGive ten numbers: ");
            Console.WriteLine(tenNumbers());
        }

        //Checks if the user input can be parsed and in error asks a number again
        static int Parse ()
        {
            string newInput = "";
            bool parse = int.TryParse(Console.ReadLine(), out int output);
            for (int i = 0; i < 5;i++)
            {
                bool parse1 = int.TryParse(newInput, out int result);
                if (parse == true)
                {
                    break;
                }
                else if (parse1 == true)
                {
                    output = result;
                    break;
                }
                else
                {
                    Console.WriteLine("Input is not a valid number, enter a new number:");
                    newInput = Console.ReadLine();
                }
            }
            return output;
        }

        static string Star (int input)
        {
            string output = "";
            for (int i = 1; i <= input; i++)
            {
                Console.Write($"{output}*");
            }
            return output;
        }

        static string Minimi (int i, int j)
        {
            string o = "";
            if (i < j)
            {
                Console.WriteLine($"Number {i} is smaller than number {j}");
            }
            else if (i > j)
            {
                Console.WriteLine($"Number {j} is smaller than number {i}");
            }
            else
            {
                Console.Write("Error");
            }
            return o;
        }

        static int numberFromRange(int low, int upper)
        {
            int output = 0, inputNumber;
            bool going = false;

            do
            {
                inputNumber = Parse();
                if (inputNumber >= low && inputNumber <= upper)
                {
                    going = true;
                    output = inputNumber;
                }
                else
                {
                    Console.WriteLine("Input was not within range");
                }
            } while (going == false);

            return output;
        }

        static int positiveNumber()
        {
            int result, output;
            do
            {
                result = Parse();
                if (result < 1)
                {
                    Console.WriteLine("Enter a positive number!");
                }
            } while (result < 1);
            output = result;
            return output;
        }

        static string tenNumbers ()
        {
            string outputNum = "";
            int maxIndex = 0, maxIndexNum = 0;
            for (int i = 1;i <= 10;i++)
            {
                Console.Write($"{i}. ");
                int n = positiveNumber();
                outputNum += $"{n} ";
                if(n > maxIndex)
                {
                    maxIndex = n;
                    maxIndexNum = i;
                }
            }

            string output = $"\nYou entered following numbers:\n{outputNum}\n\nThe biggest number was {maxIndex} and it was {maxIndexNum}. number";
            return output;
        }
    }
}