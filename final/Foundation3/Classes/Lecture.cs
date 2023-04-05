namespace Foundation3.Classes
{
    public class Lecture : Event
    {
        private string _speakerName;
        private int _capacity;

        public Lecture(string speakerName, int capacity, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address, "Lecture")
        {
            _speakerName = speakerName;
            _capacity = capacity;
        }

        public override string ReturnFullDetails()
        {
            string part1 = this.ReturnStandardDetails();
            string part2 = $"{_speakerName} will be speaking, and there will only be {_capacity} seats available.";

            return $"{part1}\n{part2}";
        }


        
    }
}