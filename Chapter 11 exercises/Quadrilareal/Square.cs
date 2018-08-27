using System;

public class Square : Quadrilateral
{
    public Square(Point point1, Point point2, Point point3, Point point4)
        : base(point1, point2, point3, point4)
    {

    }

    public override double Area()
    {
        double a = Point1.X - Point2.X;
        return a * a;
    }

}

