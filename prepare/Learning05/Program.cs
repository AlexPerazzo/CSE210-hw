using System;
using Learning05.Classes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("blue", 5);
        // square.SetColor("blue");
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Circle circle = new Circle("orange", 1);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        Rectangle rectangle = new Rectangle("purple", 5, 3);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);

        foreach (Shape item in shapes)
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
        }
    }
}