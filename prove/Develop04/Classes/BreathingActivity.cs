namespace Develop04.Classes
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {}

        public override void Execute()
        {
            StartActivity();
            BreatheInAndOut();
            EndMessage();
        }
        public void BreatheInAndOut()
        {
            int time = _duration;
            while (time > 6)
            {
            Console.WriteLine("Breath in. . . ");
            CountDownFrom(5);
            Console.WriteLine("Breath out. . . ");
            CountDownFrom(5);
            time = time - 10;
            }
        }

    }
}