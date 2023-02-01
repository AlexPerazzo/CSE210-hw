using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        PromptGenerator PromptGenerator = new PromptGenerator();
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
    }
}