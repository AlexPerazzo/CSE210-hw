namespace Develop04.Classes
{
    public class Activity
    {
        private string _activityName;
        private string _description;
        protected int _duration;

        public Activity(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;
        }

        public Activity()
        { }

        public virtual void Execute()
        { }
        public void LoadingScreen(int num)
        {
            DateTime currentTime = DateTime.Now;
            DateTime futureTime = currentTime.AddSeconds(num);

            Console.Write("");
            while (currentTime < futureTime)
            {
                Console.Write("-");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Console.Write("|");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(300);
                Console.Write("\b \b");
                currentTime = DateTime.Now;
            }
        }

        public void CountDownFrom(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{num - i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public void StartActivity()
        {
            Console.WriteLine("");
            Console.WriteLine($"Welcome to the {_activityName}");
            Console.WriteLine("");
            Console.WriteLine(_description);
            Console.WriteLine("");
            SetDurationFromInput();
        }

        public void SetDurationFromInput()
        {
            Console.Write("How long, in seconds, would you like for your session? (over 10 sec) ");
            _duration = int.Parse(Console.ReadLine());
        }

        public void EndMessage()
        {
            Console.WriteLine("Well Done!!");
            Console.WriteLine("");
            Console.Write($"You have completed {_duration} seconds of the {_activityName}.");
        }
    }
}