using System;

namespace IFteht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;

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
            Console.ReadLine();
        }
    }
}
