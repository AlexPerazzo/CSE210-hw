using System;
using Develop03.Classes;
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        // Reference reference = new Reference("");

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Which scripture would you like to study (1, 2, or 3)?");
        Console.WriteLine("1. Helaman 5:12");
        Console.WriteLine("2. Moroni 7:45");
        Console.WriteLine("3. Mosiah 3:19");
        Console.Write("> ");
        string i = Console.ReadLine();
        int answer = int.Parse(i);



        (List<Word> instanceList, Reference reference) = scripture.SplitWords(answer);
        scripture.DisplayScripture(instanceList, reference);

        bool check = true;
        while (check)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide words. Type 'quit' when done.");
            string response = Console.ReadLine();

            if (response != "quit")
            {
                instanceList = scripture.HideWords(instanceList, 4);
            }
            else
            {
                check = false;
            }

            scripture.DisplayScripture(instanceList, reference);

            check = scripture.CheckHiddenWords(instanceList);
        }

    }
}