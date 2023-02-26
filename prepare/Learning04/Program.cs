using System;
using Learning04.Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Alex P.", "Linear Algebra");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Section 1", "Problems 1-7", "ATP", "LinAlg");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment writingAssignment = new WritingAssignment("The Best Book", "ATP", "Writing 101");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}