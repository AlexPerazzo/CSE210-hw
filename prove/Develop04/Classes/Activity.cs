namespace Develop04.Classes
{
    public class Activity
    {
        string _activityName;
        string _description;
        int _duration;

        public Activity(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;
        }

        public Activity()
        {}

        public void LoadingScreen(int num)
        {
            Console.WriteLine("Please Wait.  ");
            Console.Clear();
            Console.WriteLine("Please Wait . ");
            Console.Clear();
            Console.WriteLine("Please Wait  .");
            Console.Clear();
        }

        public void CountDownFrom(int num)
        {

        }

        public void StartActivity()
        {

        }

        public void SetDurationFromInput()
        {

        }

        public void EndMessage()
        {

        }
    }
}