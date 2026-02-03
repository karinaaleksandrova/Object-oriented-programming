
using Collection_Exercise;

List<Shape> shapes = new List<Shape>();
shapes.Add(new Rectangle("Rectangle", "Green"));
shapes.Add(new Triangle("Triangle", "Yellow"));
shapes.Add(new Circle("Circle", "Red", 5));
shapes.Add(new Circle("Circle", "Blue", 1.5));

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.GetInfo());
}
Console.WriteLine("Printing only Rectangles.....");
foreach (Shape shape in shapes)
{
    if (shape is Rectangle)
    {
        Console.WriteLine(shape.GetInfo());
    }
}
