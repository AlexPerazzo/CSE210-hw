namespace Learning03.Classes
{
    public class Fraction
    {
        private int _top;
        private int _bottom;

        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int topNum)
        {
            _top = topNum;
            _bottom = 1;
        }

        public Fraction(int topNum, int botNum)
        {
            _top = topNum;
            _bottom = botNum;
        }


        public int GetTop()
        {
            return _top;
        }

        public int GetBottom()
        {
            return _bottom;
        }

        public void SetTop(int topNum)
        {
            _top = topNum;
        }

        public void SetBottom(int botNum)
        {
            _bottom = botNum;
        }

        public string GetFractionString()
        {
            return "";
        }
    }


}