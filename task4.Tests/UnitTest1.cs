namespace task4.Tests;

public class Tests
{
    [Test]
    public void DistanceBetweenPointsCorrect()
    {
        Point point1 = new Point(-1, 1);
        Point point2 = new Point(1, 1);
        double distance = 2.0;
        
        Assert.AreEqual(distance, point1.DistanceTo(point2));
    }
}