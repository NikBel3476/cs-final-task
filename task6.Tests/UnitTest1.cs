namespace task6.Tests;

public class Tests
{
    [Test]
    public void Sort_IsCorrect()
    {
        var arr = new string[] { "c", "a", "b", "ba", "aa", "ac", "aa", "aa"};
        var sortedArray = new string[] { "a", "aa", "aa", "aa", "ac", "b", "ba", "c" };
        Assert.AreEqual(sortedArray, SortService.Sort(arr));
    }
    
    /*[Test]
    public void Sort2_IsCorrect()
    {
        var arr = new string[] { "c", "a", "b", "ba", "aa", "ac", "aa", "aa"};
        var sortedArray = new string[] { "a", "aa", "aa", "aa", "ac", "b", "ba", "c" };
        Assert.AreEqual(sortedArray, SortService.Sort2(arr));
    }*/
}