using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("Give a number of how many stars you'd like to see: ");
            int input = Parse(Console.ReadLine());
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

            Console.WriteLine("\n");
            //taks2
            Console.WriteLine("Give two numbers: ");
            int in1 = Parse(Console.ReadLine());
            int in2 = Parse(Console.ReadLine());
            Minimi(in1, in2);

            Console.WriteLine("\n");
            //task 3

        }

        static int Parse (string input)
        {
            int output = 0;
            string newInput = "";

            for (int i = 0; i < 5;i++)
            {
                bool parse = int.TryParse(input, out output);
                bool parse1 = int.TryParse(newInput, out output);
                if (parse == true || parse1 == true)
                {
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
    }
}
