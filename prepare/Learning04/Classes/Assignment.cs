namespace Learning04.Classes
{
    public class Assignment
    {
        protected string _studentName;
        protected string _topic;

        public Assignment(string name, string topic)
        {
            _studentName = name;
            _topic = topic;
        }
        public Assignment()
        {}

        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }

    
}