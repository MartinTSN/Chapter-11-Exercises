using System;

public class Parellelogram : Quadrilateral
{
    public Parellelogram(Point point1, Point point2, Point point3, Point point4)
        : base(point1, point2, point3, point4)
    {

    }

    public override double Area()
    {
        double b = Math.Abs(Point1.X - Point2.X);
        double a = Math.Abs(Point1.Y - Point3.Y);

        return Math.Abs(b * (Point1.Y - Point3.Y));

    }
}

