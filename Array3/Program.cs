using System;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("Hello World!");
            do
            {
                Console.WriteLine("\nChoose from tasks x - x by typing the corresponding number. To exit type 'exit'.");
                input = Console.ReadLine();
                if (input == "exit")
                {
                    Console.WriteLine("Bye bye!");
                }
                else if (input == "1")
                {
                    Task1();
                }
                else if (input == "2")
                {
                    Task2();
                }
                else
                {
                    Console.Write("Task was not found :( ");
                }
            } while (input != "exit");
        }

        static void Task1()
        {
            Console.WriteLine("Task 1:");
            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length;i++)
            {
                array[i] = rnd.Next(0, 20);
            }
            Console.WriteLine("[X] = Value");
            for (int i = 0; i < array.Length; i++)
            {
                string num = array[i].ToString("00");
                Console.WriteLine($"[{i}] = {num}");
            }
        }

        static void Task2()
        {
            Console.WriteLine("Task 2:");
            Random rnd = new Random();
            int[,] array2D = new int[10, 20];
            for (int i = 0;i < 10; i++)
            {
                array2D[i,i] = rnd.Next(0, 100);
            }
            Console.WriteLine("[X] = Value");
            for (int i = 0; i < 10; i++)
            {
                string num = array2D[i,i].ToString("00");
                Console.WriteLine($"[{i}] = {num}");
            }
        }
    }
}
