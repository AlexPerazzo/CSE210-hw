namespace Develop04.Classes
{
    public class ReflectingActivity : Activity
    {
        List<string> _promptList = new List<string>() {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};

        List<string> _questionList = new List<string>()
            {"Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"};

        public ReflectingActivity() : base("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {}

        public override void Execute()
        {
            StartActivity();
            DisplayPrompt();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            CountDownFrom(5);
            int time = _duration;
            while (time > 0)
            {
                DisplayQuestion();
                LoadingScreen(8);
                time = time - 8;
            }
            EndMessage();
        }

        public void DisplayPrompt() 
        {
            Random random = new Random();
            int num = random.Next(0, _promptList.Count() - 1);
            Console.WriteLine($"--- {_promptList[num]} ---");
            Console.WriteLine("");
            Console.Write("When you have something in mind, press enter to continue.");
            Console.ReadLine();
        }

        public void DisplayQuestion()
        {
            Random random = new Random();
            int num = random.Next(0, _questionList.Count() - 1);
            Console.WriteLine("");
            Console.WriteLine(_questionList[num]);
            Console.WriteLine("");
        }

        
    }
}