namespace Develop03.Classes
{

    public class Scripture
    {

        private Dictionary<string, string> _scripture = new Dictionary<string, string>() {{"Helaman 5:12", "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."}, {"Moroni 7:45", "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things."}, {"Mosiah 3:19", "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."}};
        private List<int> _isHiddenList = new List<int>();
        private string _reference;

        public List<Word> splitWords()
        {
            List<Word> instanceList = new List<Word>();
            Random random = new Random();
            int ranIndex = random.Next(0, 3);
            string[] words = _scripture[ranIndex].Split(" ");
            foreach (string i in words)
            {
                Word word = new Word(i);
                instanceList.Add(word);
            }
            return instanceList;
        }

    }
}