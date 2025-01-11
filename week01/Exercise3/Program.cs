using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("I have my magic number. can you guess it?(1-100)");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -100;


        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}