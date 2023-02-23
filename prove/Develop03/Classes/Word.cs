namespace Develop03.Classes
{

    public class Word
    {
        private string _singleWord;
        private bool _isHidden;

        public Word(string word)
        {
            _singleWord = word;
            _isHidden = false;
        }

        public Word(string word, bool hidden)
        {
            _singleWord = word;
            _isHidden = true;
        }


        public void DisplayWord()
        {
            Console.Write(_singleWord);
            Console.Write(" ");
        }
        public string HideWord()
        {
            List<string> underscoreList = new List<string>();
            int length = _singleWord.Length;
            for (int i = 0; i < length; i++)
            {
                underscoreList.Add("_");
            }
            string underscore = string.Join("", underscoreList);
            return underscore;
        }

        public string GetSingleWord()
        {
            return _singleWord;
        }

        public bool GetIsHidden()
        {
            return _isHidden;
        }

    }
}