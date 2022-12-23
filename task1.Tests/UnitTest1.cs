using task1;

namespace task1.Tests;

public class Tests
{
    [Test]
    public void NumberIsPrimeReturnsTrue()
    {
        Assert.True(MathService.IsPrime(5));
        Assert.True(MathService.IsPrime(11));
        Assert.True(MathService.IsPrime(239));
        Assert.True(MathService.IsPrime(5261));
        Assert.True(MathService.IsPrime(17569));
    }

    [Test]
    public void NumberIsNotPrimeReturnsFalse()
    {
        Assert.False(MathService.IsPrime(0));
        Assert.False(MathService.IsPrime(1));
        Assert.False(MathService.IsPrime(4));
        Assert.False(MathService.IsPrime(18));
        Assert.False(MathService.IsPrime(150));
    }
}