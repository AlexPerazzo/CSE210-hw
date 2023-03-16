namespace Develop05.Classes
{

    public class SimpleGoal : Goal
    {

        public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
        {
        }

        // Add getters and setters if I want later
        public override int GetPoints()
        {
            int result = 0;
            if (IsComplete())
            {
                result = _points;
            }
            return result;
            
        }

        public virtual void RecordProgress()
        {
            // different for each goal; mark the goal as complete
            _complete = true;
        }


        public override string ToString()
        {
            // TODO: This is cruddy, make a better goal string
            return $"The simple goal is complete: {_complete}";
        }
    }
}