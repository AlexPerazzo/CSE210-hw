namespace Foundation3.Classes
{
    public class OutdoorGathering : Event
    {
        private string _weather;

        public OutdoorGathering(string weather, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address, "Outdoor Gathering")
        {
            _weather = weather;
        }

        public override string ReturnFullDetails()
        {
            string part1 = this.ReturnStandardDetails();
            string part2 = $"It will be {_weather} outside.";

            return $"{part1}\n{part2}";
        }


    }
}