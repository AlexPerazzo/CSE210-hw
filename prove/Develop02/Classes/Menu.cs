using System;
using Develop02.Classes;

public class Menu
{
    public Journal _journal = new Journal();
    public PromptGenerator _pG = new PromptGenerator();

    public Entry _entry = new Entry();

    public List<string> startUp()
    {
        List<string> entryList = new List<string>();

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("What would you like to do:");
        Console.WriteLine("1. Load from an existing file");
        Console.WriteLine("2. Start a new file");
        Console.Write("> ");
        string response = Console.ReadLine();
        if (response == "1")
        {
            entryList = _journal.loadFile();
        }
        else if (response == "2")
        {
            Console.WriteLine("Sounds good! You will be asked for a filename to save it to when you choose to save within the program.");
        }
        else
        {
            Console.WriteLine("Invalid entry; please try again.");
            startUp();
        }

        return entryList;
    }
    public void menu(List<string> entryList)
    {
        // entryList = new List<string>();
        bool run = true;
        while (run)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            string response = Console.ReadLine();


            switch (response)
            {

                case "1":
                    string entry = _entry.createEntry();
                    entryList.Add(entry);
                    break;

                case "2":
                    _journal.displayAllEntries(entryList);
                    break;

                case "3":
                    Console.WriteLine("This will replace all entries (not saved in a different file) with those in the file you choose. Type 'yes' if you wish to continue.");
                    Console.Write("> ");
                    string response2 = Console.ReadLine();
                    if (response2 == "yes")
                    {
                    entryList = _journal.loadFile();
                    }
                    else
                    {
                    }

                    break;

                case "4":
                    _journal.saveEntry(entryList);
                    break;

                case "5":
                    Console.WriteLine("Thanks for coming!");
                    run = false;
                    break;

                default:
                    Console.WriteLine("error; invalid response");
                    break;
            }
        }


        // PromptGenerator PromptGenerator = new PromptGenerator();
        // string prompt = PromptGenerator.GetRandomPrompt();
        // Console.WriteLine(prompt);
    }
}