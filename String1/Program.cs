using System;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Hello World!\n");
            do
            {
                Console.WriteLine("Choose from tasks x - x by typing the corresponding number. To exit type 'exit'.");
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
                else if (input == "4")
                {
                    Task4();
                }
                else
                {
                    Console.Write("Task was not found :( ");
                }
            } while (input != "exit");
        }

        static void Task1()
        {
            Console.WriteLine("Task1\nType a text:");
            string s = Console.ReadLine();
            Console.WriteLine($"Input '{ s}' has {s.Length} characters.");
        }

        static void Task2()
        {
            Console.WriteLine("Task2\nType a text:");
            string s = Console.ReadLine();
            Console.WriteLine(s.Replace("e", "@"));
        }

        static void Task3()
        {
            Console.WriteLine("Task3\nType a text:");
            string s = Console.ReadLine();
            char letter = 'L';
            int count = Task3LoopCheck(ref s, ref letter);
            Console.WriteLine($"There are {count} L:s on the input '{s}'");
        }

        static int Task3LoopCheck(ref string s, ref char letter)
        {
            int count = 0;
            string upperS = s.ToUpper();
            for (int i = 0; i < s.Length; i++)
            {
                if (upperS[i].Equals(letter))
                {
                    count++;
                }
            }
            return count;
        }

        static void Task4()
        {
            Console.WriteLine("Task4\nType a text:");
            string input = Console.ReadLine();
            bool isPalindrome = Task4PalindromeCheck(input);
            if (isPalindrome == true)
            {
                Console.WriteLine($"Input '{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"Input '{input}' is not a palindrome.");
            }
        }

        static bool Task4PalindromeCheck(string input)
        {
            string reversed = Task4Reverse(input);
            bool isPalindrome;
            if (reversed.ToUpper() == input.ToUpper())
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
            return isPalindrome;
        }

        static string Task4Reverse(string input)
        {
            string reverse = "";
            for (int i = input.Length -1; i >= 0; i--)
            {
                reverse += input[i];
            }
            return reverse;
        }
    }
}
