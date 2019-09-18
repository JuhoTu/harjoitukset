using System;

namespace IFteht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 16, cust, stud;

            Console.WriteLine("Hei, syötä tasoasi vastaava numero.\n 0. Normaali hinta\n 1. Alle 7 vuotias\n 2. Yli 65 vuotias\n 3. 7-15 vuotias\n 4. MTK jäsen\n 5. Varusmies\n 6. Opiskelija");

            cust = Convert.ToInt32(Console.ReadLine());

            if (cust == 1)
            {
                Console.WriteLine("Lippu on ilmainen");
            }
            else if (cust == 2 || cust == 3 || cust == 5)
            {
                Console.WriteLine("Lipun hinta on: {0}€", price * 0.5);
            }
            else if (cust == 4)
            {
                Console.WriteLine("Lipun hinta on: {0}€", price * 0.85);
            }
            else if (cust == 6)
            {
                Console.WriteLine("Oletko MTK-jäsen?\n 1. Olen\n 2. En ole");
                stud = Convert.ToInt32(Console.ReadLine());

                if (stud == 1)
                {
                    Console.WriteLine("Lipun hinta on: {0}€", price * 0.55 * 0.85);
                }
                else
                {
                    Console.WriteLine("Lipun hinta on: {0}€", price * 0.55);
                }

            }
            else
            {
                Console.WriteLine("Lipun hinta on: {0}€", price);
            }
        }
    }
}
