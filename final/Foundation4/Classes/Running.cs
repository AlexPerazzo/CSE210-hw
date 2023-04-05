namespace Foundation4.Classes3
{
    public class Running : Activity
    {
        private double _distance;

        public Running(double distance, string date, double length) : base(date, length, "Running")
        {
            _distance = distance;
        }


        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / _length) * 60;
        }

        public override double GetPace()
        {
            return (_length / _distance);
        }

    }
}