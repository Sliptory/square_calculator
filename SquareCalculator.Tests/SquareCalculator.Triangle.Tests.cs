namespace SquareCalculator.Tests;

public class TriangleTests
{
    [Fact]
    public void FromHeronsTests()
    {
        double r = SquareCalc.SquareCalculator.Triangle.FromHerons(12.5, 15.74, 24.65);

        Assert.Equal(84.17955144362188, r);
    }
}