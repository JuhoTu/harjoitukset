using System;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Inputter();
            Validator(input);
        }

        static string Inputter()
        {
            Console.WriteLine("Input account number:");
            bool form = false;
            string input;
            int bankNum = 0;
            do
            {
                input = Console.ReadLine();
                if (input.Length > 8 && input.Length < 15)
                {
                    form = BankChecker(input, ref bankNum);
                    input = input.Replace("-", "");
                    Zeros(ref input, bankNum);
                    CheckNumber(input);
                }
                else
                {
                    Console.WriteLine("Invalid account number! Length is not valid");
                }
            } while (form == false);
            return input;
        }

        static bool BankChecker(string input, ref int bankNum)
        {
            bool formCheck = false;
            if (input[0].Equals('4') || input[0].Equals('5'))
            {
                formCheck = true;
                bankNum = int.Parse(input[0].ToString());
            }
            else if(input[0].Equals('1') || input[0].Equals('2') || input[0].Equals('6') || input[0].Equals('8'))
            {
                formCheck = true;
                bankNum = int.Parse(input[0].ToString());
            }
            else if (input[0].Equals('3') && input[1].Equals('1') || input[1].Equals('3') || input[1].Equals('4') || input[1].Equals('6') || input[1].Equals('7') || input[1].Equals('8') || input[1].Equals('9'))
            {
                formCheck = true;
                bankNum = 30 + int.Parse(input[1].ToString());
            }
            else
            {
                Console.WriteLine("Invalid account number!");
            }
            return formCheck;
        }

        static void Zeros(ref string input, int bankNum)
        {
            int length = 14 - input.Length;
            if (bankNum == 4 || bankNum == 5)
            {
                for (int i = 0; i < length; i++)
                {
                    input = input.Insert(i + 7, "0");
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    input = input.Insert(i + 6, "0");
                }
            }
            Console.WriteLine(input);
        }

        static void CheckNumber(string input)
        {
            string removed = input.Remove(12, 1);
            
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(removed);
            }
        }

        static void Validator(string input)
        {
            Console.WriteLine(input);
        }
    }
}
