namespace Develop05.Classes
{

    public class EternalGoal : Goal
    {

        public EternalGoal(string name, string desc, int points) : base(name, desc, points)
        {
        }

        // Add getters and setters if I want later
        

        public override void RecordProgress()
        {
            // different for each goal
        }

        public override string ToString()
        {
            // TODO: This is cruddy, make a better goal string
            return $"The goal is complete: {_complete}";
        }
    }
}