namespace SquareCalculator.Tests;

public class DefaultTests
{
    [Fact]
    public void RadiusCalculateTest()
    {
        double r = SquareCalc.SquareCalculator.GetSquare(5.87);
        Assert.Equal(108.250, r);
    }

    [Fact]
    public void TriangleCalculateTest()
    {
        double r = SquareCalc.SquareCalculator.GetSquare(2, 5, 6);
        Assert.Equal(4.684, r);
    }

    [Fact]
    public void RightTriangleCalculateTest()
    {
        Assert.True(SquareCalc.SquareCalculator.IsStraightTriangle(6, 11, 12.53));
    }

    [Fact]
    public void NotRightTriangleCalculateTest()
    {
        Assert.False(SquareCalc.SquareCalculator.IsStraightTriangle(6, 11, 12));
    }
}