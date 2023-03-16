namespace Develop05.Classes
{
    public class InMemRepository : Repository
    {

        private List<Goal> _goals = new List<Goal>();


        public void Add(Goal goal)
        {
            if (!_goals.Contains(goal))
            {
                _goals.Add(goal);
            }
        }

        public List<Goal> GetAll()
        {
            return _goals;
        }

        public void Remove(Goal goal)
        {
            if (_goals.Contains(goal))
            {
                _goals.Remove(goal);
            }
        }

    }

}