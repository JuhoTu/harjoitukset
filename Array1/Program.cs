using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("Products:");
            decimal[] productPrice = { 7.96m, 72.0m, 99.90m };
            int[] productAmount = { 1, 3, 2 };
            decimal[] productTotalPrice = new decimal[3];
            for (int i = 0;i < 3;i++)
            {
                productTotalPrice[i] = productPrice[i] * productAmount[i];
                Console.WriteLine($"Product {i+1}: {productTotalPrice[i]}");
            }

            //task 2
            Console.WriteLine("\n\nRandom numbers:");
            int[] iT = new int[100];
            Random rnd = new Random();
            double average = 0;
            for (int i = 0; i < 100; i++)
            {
                iT[i] = rnd.Next(1,101);
                Console.WriteLine($"{i+1}. {iT[i]}");
                average = average + iT[i];
            }
            Console.WriteLine($"Average number was {average / 100}");

        }
    }
}
