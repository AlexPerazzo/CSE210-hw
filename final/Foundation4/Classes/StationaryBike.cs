namespace Foundation4.Classes3
{
    public class StationaryBike : Activity
    {
        private double _speed;

        public StationaryBike(double speed, string date, double length) : base(date, length, "Stationary Bike")
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return (_speed * _length / 60);
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60 / _speed;
        }
    }
}