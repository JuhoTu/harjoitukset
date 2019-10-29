using System;

namespace Kertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("Give a sentence you'd like to see: ");
            string input = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(input);
            }

            //task 2
            Console.WriteLine("\nGive a sentence and it will be printed as many times as there are characters on it: ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input);
            }

            //task 3
            Console.WriteLine("\nGive numbers you'd like to sum up. Typing 0 will stop.");
            int numInput, numSum = 0;
            do
            {
                numInput = int.Parse(Console.ReadLine());
                numSum = numSum + numInput;
            } while (numInput != 0);
            Console.WriteLine($"Inputted numbers sum is {numSum}");

            //task 4
            Console.WriteLine("\nGive two numbers you'd like to be computed on basic arithmatic operators: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} : {num2} = {num1 / num2}");

        }
    }
}
