using System;
using Develop03.Classes;
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Word word;
        bool check = true;
        // Word word;

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
            List<Word> instanceList = scripture.splitWords(answer);
            while (check)
            {
                scripture.DisplayScripture(instanceList);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Press ENTER to hide words. Type 'quit' when done.");
                string response = Console.ReadLine();

                if (response != "quit") 
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Random random = new Random();
                        int index = random.Next(0, instanceList.Count);
                        if (instanceList[index].GetIsHidden() == false)
                        {
                            string underscore = instanceList[index].HideWord();
                            Word newWord = new Word(underscore, true);
                            instanceList[index] = newWord;
                        }
                        else
                        {
                            j--;
                        }
                    }
                }

                else
                {
                    check = false;
                }
            }
        }

        else if (answer == 2)
        {
            List<Word> instanceList = scripture.splitWords(answer);
            scripture.DisplayScripture(instanceList);
        }

        else if (answer == 3)
        {
            List<Word> instanceList = scripture.splitWords(answer);
            scripture.DisplayScripture(instanceList);
        }

    }
}