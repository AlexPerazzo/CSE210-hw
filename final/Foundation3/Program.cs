using System;
using Foundation3.Classes;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Happy Place", "Fallon", "Nevada", "USA");
        Address address2 = new Address("525 S Center Street", "Rexburg", "Idaho", "USA");
        Address address3 = new Address("345 S 3rd W", "Murray", "Utah", "USA");

        OutdoorGathering outdoorgathering = new OutdoorGathering("Sunny", "Picnic", "Wonderful food outside on a wonderful day!", "6/5/2023", "5:00pm", address1);
        Lecture lecture = new Lecture("John Bytheway", 127, "Turtle Talks", "Come here John Bytheway teach us about the Gospel of Christ", "12/12/2023", "7:00pm", address2);
        Reception reception = new Reception("AllEmails@gmail.com", "My Wedding Reception", "Please come visit with me and my spouse!", "4/22/2023", "6:00pm", address3);

        Console.WriteLine(outdoorgathering.ReturnFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorgathering.ReturnShortDesc());
        Console.WriteLine();
        Console.WriteLine(outdoorgathering.ReturnStandardDetails());
        Console.WriteLine();

        Console.WriteLine(lecture.ReturnFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ReturnShortDesc());
        Console.WriteLine();
        Console.WriteLine(lecture.ReturnStandardDetails());
        Console.WriteLine();

        Console.WriteLine(reception.ReturnFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ReturnShortDesc());
        Console.WriteLine();
        Console.WriteLine(reception.ReturnStandardDetails());
        Console.WriteLine();
    }
}