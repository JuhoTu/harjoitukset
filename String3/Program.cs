using System;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool input = Inputter();
            Print(input);
        }

        static bool Inputter()
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
                    bool bankCheck = BankChecker(input, ref bankNum);
                    input = input.Replace("-", "");
                    Zeros(ref input, bankNum);
                    if (bankCheck == true && CheckNumber(input) == true)
                    {
                        form = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid bank or check number!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid account number! Length is not valid");
                }
            } while (form == false);
            return form;
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
            else if (input[0].Equals('3'))
            {
                if (input[1].Equals('1') || input[1].Equals('3') || input[1].Equals('4') || input[1].Equals('6') || input[1].Equals('7') || input[1].Equals('8') || input[1].Equals('9'))
                {
                    formCheck = true;
                    bankNum = 30 + int.Parse(input[1].ToString());
                }
                else
                    Console.WriteLine("Invalid account number!");
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
        }

        static bool CheckNumber(string input)
        {
            string removed = input.Remove(12, 1);
            int sum = 0, addedNum, checkNumOrig = int.Parse(input[13].ToString());
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 2)
                {
                    addedNum = int.Parse(removed[i].ToString()) * 2;
                    sum = sum + addedNum;
                }
                else
                {
                    sum = sum + int.Parse(removed[i].ToString());
                }
            }
            int checkNum = (sum + checkNumOrig) - sum;
            if (checkNum == checkNumOrig)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Print(bool input)
        {
            if (input == true)
            {
                Console.WriteLine("BBAN is valid!");
            }
            else
            {
                Console.WriteLine("Not a valid BBAN!");
            }
        }
    }
}
