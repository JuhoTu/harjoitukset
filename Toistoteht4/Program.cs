using System;

namespace Toistoteht4
{
    class Program
    {
        static void Main(string[] args)
        {
            //teht1
            double i = 0;

            Console.WriteLine("luku    neliöjuuri");

            while (i <= 10)
            {
                Console.Write("\n{0}       {1}",i,Math.Sqrt(i));
                i++;
            }

            Console.WriteLine("\n");
            //teht2
            i = 1;
            int n = 1;

            while ( n < 10 && i < 10)
            {
                Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
                i++;
                if(i == 10)
                {
                    n++;
                    i = 1;
                }
            }
            Console.WriteLine("\n");
            //teht3

            Random rnd = new Random();
            i = 0;
            n = 1;

            while (i < 6)
            {
                Console.WriteLine("\nRivi {0}:", i);
                i++;
                while (n <= 20)
                {
                    Console.WriteLine(rnd.Next(50));
                    n++;
                }
            }





        }
    }
}
