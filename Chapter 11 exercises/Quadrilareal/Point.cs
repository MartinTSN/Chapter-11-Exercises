using System;

public class Point
{
    private double y;
    private double x;
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }

    public double Y
    {
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }
}

