namespace SquareCalc.Shapes;

internal class Circle : AbstractShape
{
    public Circle(double radius) : base(radius) { }

    public override double GetSquare() => Math.Round(Math.PI * values[0] * values[0], 3);

    public override bool IsExist() => values[0] > 0;
}
