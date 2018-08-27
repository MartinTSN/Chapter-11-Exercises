using System;

public class Trapezoid : Quadrilateral
{
    public Trapezoid(Point point1, Point point2, Point point3, Point point4)
        : base(point1, point2, point3, point4)
    {

    }

    public override double Area()
    {
        double a = Point1.X - Point2.X;
        double b = Point3.X - Point4.X;

        double h = Point1.Y - Point3.Y;
        if (a < 0)
        {
            a = Math.Abs(a);
        }
        if (b < 0)
        {
            b = Math.Abs(b);
        }
        if (h < 0)
        {
            h = Math.Abs(h);
        }

        return (a + b) / 2 * h;

    }
}

