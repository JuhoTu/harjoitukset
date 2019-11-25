using System;

namespace ArrayLotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lottoNumbers = new int[8];
            Random rnd = new Random();
            for (int i = 1; i <= 7; i++)
            {
                lottoNumbers[i] = rnd.Next(1, 40);
            }
            for (int i = 1; i <= 7; i++)
            {
                Console.Write($"{lottoNumbers[i]} ");
            }
        }
    }
}
