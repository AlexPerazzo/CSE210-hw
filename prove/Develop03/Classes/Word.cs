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
        public Word HideWord()
        {
            List<string> underscoreList = new List<string>();
            int length = _singleWord.Length;
            foreach (char letter in _singleWord)
            {
                if (char.IsLetter(letter))
                {
                underscoreList.Add("_");
                }
                else
                {
                    underscoreList.Add($"{letter}");
                }
            }
            string underscore = string.Join("", underscoreList);
            Word newWord = new Word(underscore, true);
            return newWord;
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