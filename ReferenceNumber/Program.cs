﻿using System;

namespace ReferenceNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks inputted reference number or creates new ones
            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface();
                switch (userChoise)
                {
                    // Check input
                    case 'C':
                        RefChecker();
                        break;
                    // Create a new one
                    case 'N':
                        RefCreator();
                        break;
                    // Create multiple new ones
                    case 'M':
                        RefMultiCreator();
                        break;
                    // Exit
                    case 'X':
                        break;

                    default:
                        Console.WriteLine("\nCheck input. Proceed by pressing Enter.");
                        Console.ReadLine();
                        break;
                }
                Console.ReadLine();
            } while (userChoise != 'X');
        }

        static char UserInterface()
        {
            Console.WriteLine("Reference number validator and creator.");
            Console.WriteLine("[C] Validate reference number.");
            Console.WriteLine("[N] Create a new one.");
            Console.WriteLine("[M] Create multiple.");
            Console.WriteLine("[X] Close the program.");
            Console.Write("Choose procedure: ");

            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static void RefChecker()
        {
            string input = Inputter();
            if (Validator(input) == true)
            {
                Console.WriteLine("Reference number is valid.");
            }
            else
            {
                Console.WriteLine("Reference number is invalid.");
            }
        }

        static void RefCreator()
        {
            string create = RefCreate();
        }

        static void RefMultiCreator()
        {
            int count = HowMany();
            for (int i = 0; i < count; i++)
            {
                string create = RefCreate();
                Vault(create);
            }
        }

        static string Inputter()
        {
            Console.Write("\nInput the reference number: ");
            string input = Console.ReadLine();
            RemoveSpaces(ref input);
            Console.WriteLine(input);
            return input;
        }

        static void RemoveSpaces(ref string userInput)
        {
            userInput = userInput.Replace(" ", "");
        }

        static bool Validator(string checkInput)
        {
            if (checkInput.Length > 4 && checkInput.Length < 20)
            {
                return true;
            }
            return false;
        }

        static string RefCreate()
        {
            return "0";
        }

        static int HowMany()
        {
            return 0;
        }

        static void Vault(string input)
        {

        }
    }
}