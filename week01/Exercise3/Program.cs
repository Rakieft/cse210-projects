using System;

class Program
{
    static void Main(string[] args)
    {

        bool playAgain = true;
        while (playAgain)
        {

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);

            int guess = -1;
            int attempt = 0;
            int maxattempts  = 8;


            Console.WriteLine("Welcome, What is your guess?");

            while (guess != magicNumber && attempt < maxattempts)
            {
                Console.Write("Guess your number?");
                guess = int.Parse(Console.ReadLine());
                attempt++;

                    if (magicNumber > guess)
                    {
                        Console.WriteLine("'Higher");
                    }

                    else if (magicNumber < guess)
                    {
                        Console.WriteLine("Lower");
                    }

                    else 
                    {
                        Console.WriteLine("Congratulation, You get it.");
                        break;
                    }
                }
            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
        
    }
}