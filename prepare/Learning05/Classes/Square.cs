namespace Learning05.Classes
{
    public class Square : Shape
    {
        private int _side;

        public override int GetArea()
        {
            return _side * _side;
        }

        public Square(string color, int side) : base(color)
        {
            _side = side;
        }
    }
}