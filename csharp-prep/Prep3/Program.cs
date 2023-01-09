using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        int guess;

        do
        {
            Console.Write("What's your guess? ");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            
            if (guess > magicNumber)
            {
                Console.WriteLine("Too High");
            }

            if (guess < magicNumber)
            {
                Console.WriteLine("Too Low");
            }

            if (guess == magicNumber)
            {
                Console.WriteLine("Correct!");
            }
        } while (guess != magicNumber);
    }
}