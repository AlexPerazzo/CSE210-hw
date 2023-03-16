using System;
using Develop05.Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        InMemRepository repo = new InMemRepository();

        Goal simpleGoal = new SimpleGoal("Exercise.", "60 push-ups", 250);
        Console.WriteLine(simpleGoal.ToString());



        repo.Add(simpleGoal);

        int numberOfGoals = repo.GetAll().Count;

        Console.WriteLine($"Testing Num of Goals: {numberOfGoals}");

        
    }
}