namespace Develop03.Classes
{

    public class Reference
    {
        private string _book;
        private int _chapter;
        private List<int> _verse = new List<int>();

        public Reference(string reference)
        {

            string[] parts = reference.Split(" ");
            _book = parts[0];
            string[] chapterVerse = parts[1].Split(":");
            _chapter = int.Parse(chapterVerse[0]);
            if (chapterVerse[1].Contains("-"))
            {
                string[] verses = chapterVerse[1].Split("-");
                int foo = int.Parse(verses[0]);
                int foo2 = int.Parse(verses[1]);

                _verse.Add(foo);
                _verse.Add(foo2);
            }
            else
            {
                string foo = chapterVerse[1].Trim();
                int foo2 = int.Parse(foo);
                _verse = new List<int>() { foo2 };
            }

        }

        public string GetReference()
        {
            if (_verse[0] != _verse.Last())
            {
                int firstVerse = _verse[0];
                int lastVerse = _verse.Last();
                return $"{_book} {_chapter}:{firstVerse}-{lastVerse}";
            }

            else
            {
                int firstVerse = _verse[0];
                return $"{_book} {_chapter}:{firstVerse}";
            }
        }

    }
}