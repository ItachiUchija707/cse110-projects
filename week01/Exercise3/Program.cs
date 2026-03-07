using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("Welcome to the number guessing game, let's play!");
        Boolean keepGuessing = true;
        Random randomGenerator = new Random();

        while (keepGuessing)
        {   
            int guessedTimes = 0;
            int magicNumber= randomGenerator.Next(1, 20);
            Boolean userHasWon = false;

            while (!userHasWon)
            {
                Console.Write("What is your guess? ");
                string guess= Console.ReadLine();
                int fGuess = int.Parse(guess);
                guessedTimes++;

                if (fGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (fGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessedTimes} times");
                    userHasWon = true;
                }
            }

            Console.WriteLine("Do you want to play again? ");
            string playAgain= Console.ReadLine();
                if (playAgain.ToLower() == "yes")
                {
                    keepGuessing= true;
                }
                else
                {
                    keepGuessing= false;
                    Console.WriteLine("Thank you for playing");
                }
        }  
    }
}