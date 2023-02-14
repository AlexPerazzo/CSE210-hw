namespace Develop03.Classes
{

    public class Word
    {
        private string _singleWord;
        private bool _isHidden;



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