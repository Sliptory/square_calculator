namespace SquareCalc.Shapes;

internal class Triangle : AbstractShape
{
    public Triangle (double a, double b, double c) : base(a, b, c) { }

    public override double GetSquare() => FromHerons(values[0], values[1], values[2]);

    public override bool IsExist() => values[0] > 0
                                   && values[1] > 0
                                   && values[2] > 0;

    public bool IsStraight()
    {
        double a = values[0];
        double b = values[1];
        double c = values[2];

        return a == Math.Round(Math.Sqrt(b * b + c * c), 3)
            || b == Math.Round(Math.Sqrt(a * a + c * c), 3)
            || c == Math.Round(Math.Sqrt(a * a + b * b), 3);
    }

    private static double FromHerons(double a, double b, double c)
    {
        double p = (a + b + c) / 2f;
        return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 3);
    }
}