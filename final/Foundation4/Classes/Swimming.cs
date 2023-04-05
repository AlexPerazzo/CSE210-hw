namespace Foundation4.Classes3
{
    public class Swimming : Activity
    {
        private double _numOfLaps;

        public Swimming(double numofLaps, string date, double length) : base(date, length, "Swimming")
        {
            _numOfLaps = numofLaps;
        }

        public override double GetDistance()
        {
            return (_numOfLaps * 50 / 1000);
        }

        public override double GetSpeed()
        {
            return (_numOfLaps * .05 / _length) * 60;
        }

        public override double GetPace()
        {
            return 60 / GetSpeed();
        }

    }
}