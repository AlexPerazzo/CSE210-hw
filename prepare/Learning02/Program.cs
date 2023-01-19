using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._endyear = "2020";
        job1._startyear = "2000";

        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Blizzard";
        job2._endyear = "2000";
        job2._startyear = "1991";

        // job2.Display();        


        Resume myResume = new Resume();
        myResume._name = "Alexander";
        myResume._joblist.Add(job1);
        myResume._joblist.Add(job2);

        // Console.WriteLine(myResume._joblist[0]._jobTitle);

        myResume.Display();
    }
}