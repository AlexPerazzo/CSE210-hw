using System;
using Develop04.Classes;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Activity> activities = new Dictionary<string, Activity>();
        activities["1"] = new BreathingActivity();
        activities["2"] = new ReflectingActivity();
        activities["3"] = new ListingActivity();

        string response = "";
        Activity activity = new Activity();
        while (response != "4")
        {
            Console.WriteLine("");
            activity.LoadingScreen(2);
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            response = Console.ReadLine();

            if (response == "1" || response == "2" || response == "3")
            {
                activities[response].Execute();
            }
            else if (response != "4")
            {
                Console.WriteLine("Invalid response, reloading options.");
            }
        }

    }
}