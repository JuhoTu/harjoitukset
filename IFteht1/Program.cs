using System;

namespace IFteht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;

            Console.WriteLine("Anna luku:");

            luku = Convert.ToInt32(Console.ReadLine());

            if (luku == 0)
            {
                Console.WriteLine("Luku on nolla");
            }
            else
            {
                if (luku > 0)
                {
                    Console.WriteLine("Luku on postitiivinen");
                }
                else
                {
                    Console.WriteLine("Luku on negatiivinen");
                }
            }
            Console.WriteLine("\r\n");

            Console.WriteLine("Anna uusi luku:");

            luku = Convert.ToInt32(Console.ReadLine());

            if (luku % 2 == 0)
            {
                Console.WriteLine("Luku on parillinen");
            }
            else
            {
                Console.WriteLine("Luku on pariton");
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Anna taas uusi luku");

            luku = Convert.ToInt32(Console.ReadLine());

            if (luku == 0)
            {
                Console.WriteLine("Luku on nolla");
            }
            else if (luku > 0 && luku % 2 == 0)
            {
                Console.WriteLine("Luku on positiivinen ja parillinen");
            }
            else if (luku > 0 && luku % 2 != 0)
            {
                Console.WriteLine("Luku on positiivinen ja pariton");
            }
            else if (luku < 0 && luku % 2 == 0)
            {
                Console.WriteLine("Luku on negatiivinen ja parillinen");
            }
            else
            {
                Console.WriteLine("Luku on negatiivinen ja pariton");
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Anna kolme lukua");

            int luku1, luku2;

            luku = Convert.ToInt32(Console.ReadLine());
            luku1 = Convert.ToInt32(Console.ReadLine());
            luku2 = Convert.ToInt32(Console.ReadLine());

            //luku2 isoin
            if (luku < luku1 && luku1 < luku2 && luku < luku2)
            {
                Console.WriteLine("{0}<{1}<{2}", luku, luku1, luku2);
            }
            else if (luku > luku1 && luku1 < luku2 && luku < luku2)
            {
                Console.WriteLine("{0}<{1}<{2}", luku1, luku, luku2);
            }
            //luku1 isoin
            else if (luku < luku1 && luku1 > luku2 && luku > luku2)
            {
                Console.WriteLine("{0}<{1}<{2}", luku2, luku, luku1);
            }
            else if (luku < luku1 && luku1 > luku2 && luku < luku2)
            {
                Console.WriteLine("{0}<{1}<{2}", luku, luku2, luku1);
            }
            //luku isoin
            else if (luku > luku1 && luku1 > luku2 && luku > luku2)
            {
                Console.WriteLine("{0}<{1}<{2}", luku2, luku1, luku);
            }
            else if (luku > luku1 && luku1 < luku2 && luku > luku2)
            {
                Console.WriteLine("{0}<{1}<{2}", luku1, luku2, luku);
            }

            else
            {
                Console.WriteLine("{0}{1}{2}", luku, luku1, luku2);
            }


            Console.ReadLine();
        }
    }
}
