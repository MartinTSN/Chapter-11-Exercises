using System;

public class Quadrilateral
{
    private Point point1;
    private Point point2;
    private Point point3;
    private Point point4;

    public Quadrilateral(Point point1, Point point2, Point point3, Point point4)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
        Point4 = point4;
    }
    public Point Point1
    {
        get
        {
            return point1;
        }
        set
        {
            point1 = value;
        }
    }

    public Point Point2
    {
        get
        {
            return point2;
        }
        set
        {
            point2 = value;
        }
    }
    public Point Point3
    {
        get
        {
            return point3;
        }
        set
        {
            point3 = value;
        }
    }
    public Point Point4
    {
        get
        {
            return point4;
        }
        set
        {
            point4 = value;
        }
    }

    public virtual double Area()
    {
        return (Point1.X - Point2.X) * (Point1.Y - point3.Y);
    }
}

