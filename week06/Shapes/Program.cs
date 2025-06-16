 using System;
class Program
{
    static void Main(string[] args)
    {
        // Create shapes
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        // Add them to a list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterate and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}
