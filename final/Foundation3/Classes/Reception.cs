namespace Foundation3.Classes
{
    public class Reception : Event
    {
        private string _rsvpEmail;

        public Reception(string rsvpEmail, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address, "Reception")
        {
            _rsvpEmail = rsvpEmail;
        }

        public override string ReturnFullDetails()
        {
            string part1 = this.ReturnStandardDetails();
            string part2 = $"Please make an RSVP at: {_rsvpEmail}";

            return $"{part1}\n{part2}";
        }


        
    }
}