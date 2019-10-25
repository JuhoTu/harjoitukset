using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number of how many stars you'd like to see: ");
            int input = int.Parse(Console.ReadLine());
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
    }
}
