using System;
using Develop03.Classes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Which scripture would you like to study (1, 2, or 3?)");
        Console.WriteLine("1. Helaman 5:12");
        Console.WriteLine("2. Moroni 7:45");
        Console.WriteLine("3. Mosiah 3:19");
        Console.Write("> ");
        string i = Console.ReadLine();
        int answer = int.Parse(i);

        if (answer == 1)
        {
            Console.Write("");
        }

        else if (answer == 2)
        {
            Console.Write("");
        }

        else if (answer == 3)
        {
            Console.Write("");
        }

    }
}