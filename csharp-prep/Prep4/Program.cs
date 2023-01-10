using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        List<int> minList = new List<int>();
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            
        
        string userInput = Console.ReadLine();
        number = int.Parse(userInput);


        if (number != 0)
        {
        numbers.Add(number);
        }

        if (number > 0)
        {
            minList.Add(number);
        }

        } while (number != 0);
        
        int total = 0;
        foreach (int i in numbers)
        {
            total += i;
        }

        int count = numbers.Count;

        int average;

        average = total / count;

        int max = numbers.Max();

        int min = minList.Min();

        Console.WriteLine(total);
        Console.WriteLine(average);
        Console.WriteLine(max);
        Console.WriteLine(min);

        numbers.Sort();

        foreach (int x in numbers)
        {
            Console.WriteLine("Sorted List:");
            Console.WriteLine(x);
        }
    }
}