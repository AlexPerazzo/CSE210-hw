using System;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        do
        {
            // Console.Write("What's the magic number? ");
            // string userInput = Console.ReadLine();
            Random randomGenerator = new Random();
            
            // int magicNumber = int.Parse(userInput);
            int magicNumber = randomGenerator.Next(0, 11);
            int guess;
            string userInput;
            int count = 0;

            do
            {
                Console.Write("What's your guess? ");
                userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                count ++;

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
                    Console.WriteLine($"It took you {count} tries");
                }


            } while (guess != magicNumber);
            Console.Write("Would you like to play again? ");
            answer = Console.ReadLine();
        } while (answer == "yes");
    }
}