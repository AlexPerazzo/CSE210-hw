using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string username = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);
        DisplayResult(square, username);


        
    }

    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(int number, string name)
    {
        Console.WriteLine($"{name}, your favorite number squared is {number}.");
        
    }

}