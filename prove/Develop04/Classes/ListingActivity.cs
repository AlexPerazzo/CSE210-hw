namespace Develop04.Classes
{
    public class ListingActivity : Activity
    {
        List<string> _promptList = new List<string>() {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        { }

        public void GeneratePrompt()
        {
            Random random = new Random();
            int num = random.Next(0, _promptList.Count() - 1);
            Console.WriteLine(_promptList[num]);
        }

        public List<string> UserListsItems()
        {
            return new List<string>() { "" };
        }

        public int DisplayNumItems()
        {
            return 5;
        }
    }
}