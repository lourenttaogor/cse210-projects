using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square(6, "blue");
        
        // Corrected constructor call with two arguments
        Rectangle rectangle = new Rectangle(8, 4, "White");
        
        // Corrected constructor call with two arguments
        Circle circle = new Circle(12.5, "purple");

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string shapeColor = shape.GetColor();
            Console.WriteLine(area);
             Console.WriteLine(shapeColor);
        }
    }
}