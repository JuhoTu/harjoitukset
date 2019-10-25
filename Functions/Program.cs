using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
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

            Console.WriteLine("\n");
            //taks2
            Console.WriteLine("Give two numbers: ");
            int in1 = int.Parse(Console.ReadLine());
            int in2 = int.Parse(Console.ReadLine());
            Minimi(in1, in2);

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
