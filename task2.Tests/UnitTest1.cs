using task2;

namespace task2.Tests;

public class Tests
{
    [Test]
    public void YearIsLeapReturnsTrue()
    {
        // multiple of 400
        Assert.True(LeapYearService.IsLeapYear(2000));
        // multiple of 4 but not 100
        Assert.True(LeapYearService.IsLeapYear(1004));
    }

    [Test]
    public void YearIsNotLeapReturnsFalse()
    {
        // not multiple of 4
        Assert.False(LeapYearService.IsLeapYear(2001));
        // multiple of 100 but not 400
        Assert.False(LeapYearService.IsLeapYear(1900));
    }
}