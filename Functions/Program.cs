using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kuinka monta tähteä haluat tulostaa: ");
            string input = Console.ReadLine();
            Star(input);
        }

        static string Star (string input)
        {
            string output = "";
            int n = int.Parse(input);
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{output}*");
            }
            return output;
        }
    }
}
