namespace task6.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var arr = new string[] { "c", "a", "b", "ba", "aa", "ac"};
        var sortedArray = new string[] { "a", "aa", "ac", "b", "ba", "c" };
        Assert.AreEqual(sortedArray, SortService.Sort(arr));
    }
}