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
                Console.WriteLine("\nChoose from tasks 1 - 3 by typing the corresponding number. To exit type 'exit'.");
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
                else if (input == "3")
                {
                    Task3();
                }
                else
                {
                    Console.Write("Task was not found :( ");
                }
            } while (input != "exit");
        }

        static void Task1()
        {
            Console.WriteLine("Task 1:\nRandom numbers saved on an array");
            Random rnd = new Random();
            int[] array = new int[10];
            //loop for random numbers
            for (int i = 0; i < array.Length;i++)
            {
                array[i] = rnd.Next(0, 20);
            }
            Console.WriteLine("[X] = Value");
            //loop for printing the numbers
            for (int i = 0; i < array.Length; i++)
            {
                //change the int to string that always shows two numbers
                string num = array[i].ToString("00");
                Console.WriteLine($"[{i}] = {num}");
            }
        }

        static void Task2()
        {
            Console.WriteLine("Task 2:\nRandom numbers saved on a two dimensional array");
            Random rnd = new Random();
            int[,] array2D = new int[10, 20];
            //loop for the random numbers, first loop saves for first dimension (0) and second for second dimension (0)
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {

                    array2D[i, j] = rnd.Next(100);
                }
            }
            Console.WriteLine("[X, X]  = Value");
            //printing the numbers, i counts for first dimension (0) and j for second dimension (1)
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    //testing other way to turn 1-9 to 01-09 that does it on inside of a print
                    Console.WriteLine($"[{i}, {j:d2}] = {array2D[i, j]:d2}");
                }
            }
        }

        static void Task3()
        {
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            Numbers(ref arrT_1, ref arrT_2);
            Array3(ref arrT_1, ref arrT_2, ref arrT_3);
            PrintTask3(ref arrT_1, ref arrT_2, ref arrT_3);
        }

        static void Numbers (ref int[] arrT_1, ref int[] arrT_2)
        {
            Random rnd = new Random();
            for(int i = 0;i < arrT_1.Length;i++)
            {
                arrT_1[i] = rnd.Next(50);
                arrT_2[i] = rnd.Next(50);
            }
        }

        static void Array3(ref int[] arrT_1, ref int[] arrT_2, ref int[] arrT_3)
        {
            //compare arr 1 and 2 saved numbers by index and save bigger number on index to arr 3
            for (int i = 0; i < arrT_1.Length; i++)
            {
                if (arrT_1[i] > arrT_2[i])
                {
                    arrT_3[i] = arrT_1[i];
                }
                else
                {
                    arrT_3[i] = arrT_2[i];
                }
            }
        }

        static void PrintTask3(ref int[] arrT_1, ref int[] arrT_2, ref int[] arrT_3)
        {
            Console.WriteLine("         01 02 03 04 05 06 07 08 09 10");
            Console.WriteLine("         -----------------------------");
            Console.Write($"arrT_1 =");
            //printing numbers saved on array with a loop
            for (int i = 0; i < arrT_1.Length; i++)
            {
                Console.Write($" {arrT_1[i]:d2}");
            }
            Console.Write($"\narrT_2 =");
            for (int i = 0; i < arrT_2.Length; i++)
            {
                Console.Write($" {arrT_2[i]:d2}");
            }
            Console.Write($"\narrT_3 =");
            for (int i = 0; i < arrT_3.Length; i++)
            {
                Console.Write($" {arrT_3[i]:d2}");
            }
        }
    }
}
