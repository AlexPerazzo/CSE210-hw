namespace Learning05.Classes
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle(string color, int radius) : base(color)
        {
            _radius = radius;
        }

        public override int GetArea()
        {
            double radius = Convert.ToDouble(_radius);
            double area = 3.14 * radius * radius;
            int rounded = Convert.ToInt32(area);
            return rounded;
        }
    }
}