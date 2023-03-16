namespace Develop05.Classes
{

    public class Goal
    {
        private string _name = "";
        private string _desc = "";

        protected int _points = 0;

        protected bool _complete = false;

        public Goal(string name, string desc, int points)
        {
            _name = name;
            _desc = desc;
            _points = points;
        }

        // Add getters and setters if I want later
        public virtual int GetPoints()
        {
            return _points;
        }



        public virtual void RecordProgress()
        {
            
            // different for each goal
        }

        public virtual bool IsComplete()
        {
            return _complete;
        }

        public override string ToString()
        {
            // TODO: This is cruddy, make a better goal string
            return $"The goal is complete: {_complete}";
        }
    }
}