using System;

namespace ArrayLotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to a lottery simulator! Please enter seven numbers on between 1-39:");

            int[] arrLotto = new int [40];
            int[] userLotto = new int[40];

            userNumbers(ref userLotto,7,1);
            lottoNumbers(ref arrLotto, 7, 1);
            lottoNumbers(ref arrLotto, 1, 2);
            Random rnd = new Random();
            int doubleNumber = rnd.Next(1, arrLotto.Length);
            printLottoNumbers(arrLotto, doubleNumber);
            win(arrLotto, userLotto);
        }

        static void userNumbers (ref int[] userLotto, int count, int value)
        {
            for (int i = 0; i < count; i++)
            {
                int userInput = Parse();
                if (userLotto[userInput] == 0)
                {
                    userLotto[userInput] = value;
                }
                else
                {
                    i--;
                }
            }

            Console.Write("You entered: ");
            for (int i = 0; i < userLotto.Length; i++)
            {
                if (userLotto[i] == 1)
                {
                    Console.Write($" {i}");
                }
            }
        }

        static int Parse()
        {
            string newInput = "";
            bool parse = int.TryParse(Console.ReadLine(), out int output);
            for (int i = 0; i < 5; i++)
            {
                bool parse1 = int.TryParse(newInput, out int result);
                if (parse == true && output > 0 && output < 40)
                {
                    break;
                }
                else if (parse1 == true && result > 0 && result < 40)
                {
                    output = result;
                    break;
                }
                else
                {
                    Console.Write(" - Input is not a valid number, enter a new number:");
                    newInput = Console.ReadLine();
                }
            }
            return output;
        }

        static void lottoNumbers (ref int[] arrLotto, int count, int value)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int rndNum = rnd.Next(arrLotto.Length);
                if (arrLotto[rndNum] == 0)
                {
                    arrLotto[rndNum] = value;
                }
                else
                {
                    i--;
                }
            }
        }

        static void printLottoNumbers (int[] arrLotto,int doubleNumber)
        {
            //Lotto numbers
            Console.WriteLine("\n\nCorrect lotto numbers are:");
            for (int i = 0; i < arrLotto.Length; i++)
            {

                if (arrLotto[i] == 1)
                {
                    Console.Write($"{i + 1} ");
                }
            }
            //Extra number
            Console.Write("\n\nExtra number is: ");
            for (int i = 0; i < arrLotto.Length; i++)
            {
                if (arrLotto[i] == 2)
                {
                    Console.Write($"{i}");
                }
            }
            //Double number
            Console.Write($"\n\nDouble number is: {doubleNumber}");
        }

        static void win (int[] arrLotto, int[] userInput)
        {
            if (arrLotto == userInput)
            {
                Console.WriteLine("You won! Win chance is 1 : 18 643 560 so you were extra lucky :)");
            }
        }
    }
}
