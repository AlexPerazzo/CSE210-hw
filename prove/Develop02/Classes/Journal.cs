using System.IO;

namespace Develop02.Classes
{
    public class Journal
    {
        public Entry _entry = new Entry();

        public void saveEntry(List<string> entryList)
        {
            Console.WriteLine("Where would you like to save your entries?");
            Console.WriteLine("(Please note: It will replace (instead of appending onto it) all text there.)");
            Console.Write("> ");
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                entryList.ForEach((entry) => outputFile.WriteLine($"{entry}"));
            }

        }

        public List<string> addTempEntry(string entry)
        {
            List<string> entryList = new List<string>();
            entryList.Add(entry);
            return entryList;
        }

        public void displayAllEntries(List<string> entryList)
        {
            entryList.ForEach((item) => Console.WriteLine(item));
        }

        public List<string> loadFile()
        {
            List<string> entry = new List<string>();
            List<string> entryList = new List<string>();
            List<string> fullList = new List<string>();


            Console.WriteLine("Where would you like to load entries from?");
            Console.Write("> ");
            string fileName = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(fileName);

            int i = 0;
            foreach (string line in lines)
            {
                entry.Add(line);
                i++;
                if (i == 6)
                {
                    i = 0;
                    string compiledEntry = String.Join("\n", entry);
                    entryList.Add(compiledEntry);
                    entry.Clear();
                }
            }

            // entryList.ForEach((string thing) =>
            //     {
            //         fullList = this.addTempEntry(thing);
            //     });

            return entryList;

        }
    }
}