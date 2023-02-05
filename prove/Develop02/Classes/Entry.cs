namespace Develop02.Classes
{
    public class Entry
    {



        string _date = "";
        string _prompt = "";
        string _response = "";
        string _author = "";

        public PromptGenerator _pG = new PromptGenerator();


        public void displayEntry()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_prompt}");
            Console.WriteLine($"Entry: {_response}");
            Console.WriteLine($"Author: {_author}");
        }

        public string compileEntry()
        {
            // DateTime _date = 
            string entry = $"Date: {_date}\nPrompt: {_prompt}\nEntry: {_response}\nAuthor: {_author}\n\n";
            return entry;
        }

        public string createEntry()
        {
            DateTime dateTime = DateTime.Now;
            _date = dateTime.ToString("g");
            _prompt = _pG.GetRandomPrompt();
            Console.WriteLine($"{_prompt}");
            Console.WriteLine("Please enter your response below:");
            Console.Write("> ");
            _response = Console.ReadLine();
            Console.WriteLine("Who wrote this entry?");
            Console.Write("> ");
            _author = Console.ReadLine();

            string entry = compileEntry();
            return $"{entry}";
        }

    }
}