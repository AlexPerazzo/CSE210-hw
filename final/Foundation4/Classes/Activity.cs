namespace Foundation4.Classes3
{
    public class Activity
    {
        private string _date;
        protected double _length;

        private string _activityType;

        public Activity(string date, double length, string activityType)
        {
            _date = date;
            _length = length;
            _activityType = activityType;
        }

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public void DisplaySummary()
        {
            Console.WriteLine($"{_date} {_activityType} ({_length} min)- Distance {GetDistance().ToString()} Kilometers, Speed {GetSpeed().ToString()} kmph, Pace: {GetPace().ToString()} min per kilometer");
        }

    }
}