namespace Develop03.Classes
{

    public class Reference
    {
        private string _book;
        private int _chapter;

        private List<int> _verse;


        public string getReference()
        {
            if (_verse[0] != _verse[-1])
            {
                int firstVerse = _verse[0];
                int lastVerse = _verse[-1];
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