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
            Console.WriteLine("banknum is" + bankNum);
            return input;
        }

        static bool BankChecker(string input, ref int bankNum)
        {
            bool formCheck = false;
            if (input[0].Equals('4') || input[0].Equals('5'))
            {
                formCheck = true;
                bankNum = input[0];
                Console.WriteLine(input[0]);
            }
            else
            {
                Console.WriteLine("pankki on joku muu");
            }
            return formCheck;
        }

        static void CheckNumber()
        {

        }
    }
}
