namespace Foundation3.Classes
{
    public class Event
    {
        private string _eventTitle;
        private string _description;
        private string _date;
        private string _time;
        private Address _address;

        private string _eventType;

        public Event(string eventTitle, string description, string date, string time, Address address, string eventType)
        {
            _eventTitle = eventTitle;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
            _eventType = eventType;
        }


        public string ReturnStandardDetails()
        {
            string address = _address.GetFullAddress();
            return $"{_eventTitle}: {_description} \n This will be taking place on {_date} at {_time} at the following location: \n {address}";
        }

        public virtual string ReturnFullDetails()
        {
            throw new NotImplementedException();
        }

        public string ReturnShortDesc()
        {
            string shortDesc = $"{_eventTitle} is a {_eventType} and will be held on {_date}";
            return shortDesc;
        }
        




    }


}