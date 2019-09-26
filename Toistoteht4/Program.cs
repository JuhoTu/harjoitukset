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

            for (i = 1; i <= 4; i++)
            {
                Console.Write("\nRivi {0}: ", i);
                n = 1;
                while (n <= 5)
                {

                    if (n == 5)
                    {
                        Console.Write("{0}", rnd.Next(50));
                        break;
                    }
                    else
                    {
                        Console.Write("{0}, ", rnd.Next(50));
                        n++;
                    }
                }
            }

            Console.WriteLine("\n");
            //teht4

            int kruuna = 0, klaava = 0, input;

            Console.WriteLine("Syötä luku montako arpasuoritusta suoritetaan: ");
            input = int.Parse(Console.ReadLine());

            for (i = 0; i < input;i++)
            {
                int result = rnd.Next(2);
                if (result == 1)
                {
                    kruuna++;
                }
                else if (result == 0)
                {
                    klaava++;
                }
                else
                {
                    Console.Write("Virhe");
                    break;
                }
            }
            Console.WriteLine("Rahaa on heitetty {0} kertaa.",input);
            Console.WriteLine("Klaavoja tuli {0} ja kruunoja {1}", klaava, kruuna);

            Console.WriteLine("\n");
            //teht5





        }
    }
}
