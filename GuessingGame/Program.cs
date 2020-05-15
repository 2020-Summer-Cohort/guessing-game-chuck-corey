using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game!");
            Console.WriteLine("Pick a number between 1 - 10");
            int guess1 = Convert.ToInt32(Console.ReadLine());           
            if (guess1 == 7)
            {
                Console.WriteLine("You Won!");
            }
            else if (guess1 == 0)
            {
                Console.WriteLine("You don't follow instructions. One More Guess");
            }
            else
            {
                Console.WriteLine("One More Guess");
            }
            
            int guess2 = Convert.ToInt32(Console.ReadLine());
            if (guess2 == 7)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("Game Over");
            }


        }
    }
}
