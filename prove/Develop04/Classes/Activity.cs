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
            DateTime currentTime = DateTime.Now;
            DateTime futureTime = currentTime.AddSeconds(num);

            Console.Write("Please Wait");
            while (currentTime < futureTime)
            {
                Console.Write("   ");
                Console.Write("\b\b\b   \b\b\b");                
                Thread.Sleep(300);
                Console.Write(".");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Console.Write("..");
                Thread.Sleep(300);
                Console.Write("\b\b  \b\b");
                Console.Write("...");
                Thread.Sleep(300);
                Console.Write("\b\b\b   \b\b\b");
                currentTime = DateTime.Now;
            }
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