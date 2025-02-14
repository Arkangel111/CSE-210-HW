using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(8);
        square.SetColor("Maroon");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(2, 9);
        rectangle.SetColor("Violet");
        shapes.Add(rectangle);

        Circle circle = new Circle(6);
        circle.SetColor("Orange");
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"shape: {shape.GetType().Name}");
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}