using System;

namespace Toistoteht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, input, output =1;

            Console.WriteLine("Syötä luku montako kertomaa suoritetaan:");
            input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1)
            {

                while (i <= input)
                {
                    output = output * i;
                    //En jaksa tehdä siistiä tulostetta
                    Console.WriteLine(i);
                    i++;
                }
                Console.WriteLine("Vastaus on: {0}", output);
            }
            else
            {
                Console.WriteLine("Luvun pitää olla vähintään 1");
            }


            //Teht2
            Console.WriteLine("\nSyötä luku montako summaa suoritetaan:");
            input = Convert.ToInt32(Console.ReadLine());

            output = 0;
            i = 0;

            if (input >= 1)
            {

                while (i <= input)
                {
                    output = output + i;
                    //En jaksa tehdä siistiä tulostetta
                    Console.WriteLine(i);
                    i++;
                }
                Console.WriteLine("Vastaus on: {0}", output);
            }
            else
            {
                Console.WriteLine("Luvun pitää olla vähintään 1");
            }

            //Teht3
            Console.WriteLine("\nSyötä luku montako parillisten ja parittomien summaa suoritetaan:");
            input = Convert.ToInt32(Console.ReadLine());

            int even = 0,odd = 0;
            i = 0;

            if (input >= 1)
            {

                while (i <= input)
                {
                    if (i % 2 == 0)
                    {
                        even = even + i;
                        //En jaksa tehdä siistiä tulostetta
                        Console.WriteLine(i);
                        i++;
                    }
                    else
                    {
                        odd = odd + i;
                        //En jaksa tehdä siistiä tulostetta
                        Console.WriteLine(i);
                        i++;
                    }

                    
                }
                Console.WriteLine("Vastaus on: \n Parilliset: {0}\n Parittomat: {1}", even, odd);
            }
            else
            {
                Console.WriteLine("Luvun pitää olla vähintään 1");
            }

            //Teht4
            Console.WriteLine("\nSyötä luku montako summaa suoritetaan:");
            input = Convert.ToInt32(Console.ReadLine());

            output = 0;
            i = 0;

            if (input >= 1)
            {

                while (i <= input)
                {
                    output = output + i;
                    //En jaksa tehdä siistiä tulostetta
                    Console.WriteLine(i);
                    i++;
                }
                Console.WriteLine("Vastaus on: {0}", output);
            }
            else if (input <0)
            {
                while (i >= input)
                {
                    output = output + i;
                    //En jaksa tehdä siistiä tulostetta
                    Console.WriteLine(i);
                    i--;
                }
                Console.WriteLine("Vastaus on: {0}", output);
            }
            else
            {
                Console.WriteLine("Luku ei toimi");
            }

            //Teht5
            Console.WriteLine("\nSyötä luku montako parillisten ja parittomien summaa suoritetaan:");
            input = Convert.ToInt32(Console.ReadLine());

            even = 0;
            odd = 0;
            i = 0;

            if (input >= 1)
            {

                while (i <= input)
                {
                    if (i % 2 == 0)
                    {
                        even = even + i;
                        //En jaksa tehdä siistiä tulostetta
                        Console.WriteLine(i);
                        i++;
                    }
                    else
                    {
                        odd = odd + i;
                        //En jaksa tehdä siistiä tulostetta
                        Console.WriteLine(i);
                        i++;
                    }


                }
                Console.WriteLine("Vastaus on: \n Parilliset: {0}\n Parittomat: {1}", even, odd);
            }
            if (input < 0)
            {

                while (i >= input)
                {
                    if (i % 2 == 0)
                    {
                        even = even + i;
                        //En jaksa tehdä siistiä tulostetta
                        Console.WriteLine(i);
                        i--;
                    }
                    else
                    {
                        odd = odd + i;
                        //En jaksa tehdä siistiä tulostetta
                        Console.WriteLine(i);
                        i--;
                    }


                }
                Console.WriteLine("Vastaus on: \n Parilliset: {0}\n Parittomat: {1}", even, odd);
            }
            else
            {
                Console.WriteLine("Luvun pitää olla vähintään 1");
            }


        }
    }
}
