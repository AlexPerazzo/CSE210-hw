namespace Foundation2.Classes
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateprovince;
        private string _country;

        public Address()
        { }
        public Address(string streetAddress, string city, string stateprovince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateprovince = stateprovince;
            _country = country;
        }

        public bool IsInUSA()
        {
            return _country == "USA";
        }

        public void DisplayFullAddress()
        {
            Console.WriteLine($"{_streetAddress}");
            Console.WriteLine($"{_city}, {_stateprovince}");
            Console.WriteLine($"{_country}");
        }

        public string GetFullAddress()
        {
            return $"{_streetAddress} \r\n {_city}, {_stateprovince} \r\n {_country}";
        }
    }


}