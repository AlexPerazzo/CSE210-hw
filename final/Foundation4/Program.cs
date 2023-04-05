using System;
using Foundation4.Classes3;

class Program
{
    static void Main(string[] args)
    {
        

        Running running = new Running(22, "12/5/22", 50);
        StationaryBike stationaryBike = new StationaryBike(15, "4/4/23", 50);
        Swimming swimming = new Swimming(10, "3/12/23", 40);

        List<Activity> list = new List<Activity>();

        list.Add(running);
        list.Add(stationaryBike);
        list.Add(swimming);

        foreach (Activity thing in list)
        {
            thing.DisplaySummary();
        }
    }
}