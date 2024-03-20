namespace SquareCalculator.Tests;

public class CircleTests
{
    [Fact]
    public void FromRadiusTests()
    {
        double r = SquareCalc.SquareCalculator.Circle.FromRadius(5.87);
        Assert.Equal(108.24954390547815, r);
    }
}