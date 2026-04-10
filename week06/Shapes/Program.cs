using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square("white", 5);
        Console.WriteLine(square.GetArea());
        Console.WriteLine(square.GetColor());
        Rectangle rectangle = new Rectangle("red", 5, 7);
        Circle circle = new Circle("blue", 5);
        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shapes shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} {shape.GetArea()}");
        }

    }
}