namespace SquareCalculator.Tests;

public class DefaultTests
{
    [Fact]
    public void RadiusCalculateTest()
    {
        double r = SquareCalc.SquareCalculator.Calculate(5.87);
        Assert.Equal(108.24954390547815, r);
    }

    [Fact]
    public void TriangleCalculateTest()
    {
        double r = SquareCalc.SquareCalculator.Calculate(12.5, 15.74, 24.65);
        Assert.Equal(84.17955144362188, r);
    }

    [Fact]
    public void RightTriangleCalculateTest()
    {
        double r = SquareCalc.SquareCalculator.Calculate(11, 4.8, 10);
        Assert.Equal(23.994580638135776, r);
    }
}