using System;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vowel counter\nInput text:");
            string input = Console.ReadLine();
            int count = VowelCount(input);
            Console.WriteLine($"Text '{input}' has {count} vowels");
        }

        static int VowelCount (string input)
        {
            int count = 0;
            input = input.ToLower();
            string vowels = "aeiouyäö";
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (input[i] == vowels[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
