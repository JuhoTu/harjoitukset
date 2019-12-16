using System;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Inputter();
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
                }
            } while (form == false);
            input = input.Replace("-", "");
            Console.WriteLine("banknum is " + bankNum);
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

        static void CheckNumber()
        {

        }
    }
}
