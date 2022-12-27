using task1;

namespace task1.Tests;


public class Tests
{
    [Test]
    [TestCase(5)]
    [TestCase(11)]
    [TestCase(239)]
    [TestCase(5261)]
    [TestCase(17569)]
    public void NumberIsPrime_ReturnsTrue(int value)
    {
        var result = MathService.IsPrime(value);
        
        Assert.IsTrue(result, $"{value} должено быть простым числом");
    }

    [Test]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(4)]
    [TestCase(18)]
    [TestCase(150)]
    public void NumberIsNotPrime_ReturnsFalse(int value)
    {
        var result = MathService.IsPrime(value);
        
        Assert.IsFalse(result, $"{value} не должно быть простым числом");
    }
}