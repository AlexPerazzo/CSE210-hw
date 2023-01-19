public class Resume
{
    public string _name = "";
    public List<Job> _joblist = new List<Job>();

    public void Display()
    {
        Console.WriteLine(_name);

        foreach (var job in _joblist)
        {
            job.Display();
        }
    }
}