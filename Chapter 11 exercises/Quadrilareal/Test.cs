using System;

class Test
{
    static void Main()
    {
        Point point1 = new Point(0, 0);
        Point point2 = new Point(8, 0);
        Point point3 = new Point(2, 3);
        Point point4 = new Point(10, 3);

        Parellelogram parellelogram = new Parellelogram(point1, point2, point3, point4);
        Console.WriteLine($"The height of the parellelogram is: {Math.Abs(point1.Y - point3.Y)}");
        Console.WriteLine($"The base of the parellelogram is: {Math.Abs(point1.X - point2.X)}");
        Console.WriteLine($"Parellelogram area is: {parellelogram.Area()}\n");

        point2 = new Point(8, 0);
        point3 = new Point(0, 3);
        point4 = new Point(8, 3);
        Rectangle rectangle = new Rectangle(point1, point2, point3, point4);
        Console.WriteLine($"The length of the rectangle is: {Math.Abs(point1.X - point2.X)}");
        Console.WriteLine($"The width of the rectangle is: {Math.Abs(point1.Y - point3.Y)}");
        Console.WriteLine($"Rectangle area is: {rectangle.Area()}\n");

        point2 = new Point(4, 0);
        point3 = new Point(0, 4);
        point4 = new Point(4, 4);
        Square square = new Square(point1, point2, point3, point4);
        Console.WriteLine($"The side of the square is: {Math.Abs(point1.X - point2.X)}");
        Console.WriteLine($"Square area is: {square.Area()}\n");

        point2 = new Point(14, 0);
        point3 = new Point(3, 4);
        point4 = new Point(11, 4);
        Trapezoid trapezoid = new Trapezoid(point1, point2, point3, point4);
        Console.WriteLine($"The baseB of the trapezoid is: {Math.Abs(point1.X - point2.X)}");
        Console.WriteLine($"The baseA of the trapezoid is: {Math.Abs(point3.X - point4.X)}");
        Console.WriteLine($"The height of the trapezoid is: {Math.Abs(point1.Y - point3.Y)}");
        Console.WriteLine($"Trapezoid area is: {trapezoid.Area()}");

        Console.ReadLine();
    }
}

