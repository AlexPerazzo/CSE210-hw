using System;
using Foundation1.Classes;

class Program
{
    static void Main(string[] args)
    {
        List<Video> allvids = new List<Video>();

        Populate pop = new Populate();
        Video video1 = pop.PopulateVideo1();
        Video video2 = pop.PopulateVideo2();
        Video video3 = pop.PopulateVideo3();

        allvids.Add(video1);
        allvids.Add(video2);
        allvids.Add(video3);

        foreach (Video vid in allvids)
        {
            vid.DisplayVideoInfo();
        }
    }
}