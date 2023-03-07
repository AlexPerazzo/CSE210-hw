namespace Learning05.Classes
{
    public abstract class Shape
    {
        private string _color = "";

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public Shape(string color)
        {
            _color = color;
        }

        public Shape()
        {
        }
        public virtual int GetArea()
        {
            return 0;
        }
    }
}