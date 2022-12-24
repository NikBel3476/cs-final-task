namespace task4;

public class Point
{
    public double X;
    public double Y;
    
    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }
    
    public double DistanceTo(Point p)
    {
        return Math.Sqrt(Math.Pow(p.X - this.X, 2) + Math.Pow(p.Y - this.Y, 2));
    }
}