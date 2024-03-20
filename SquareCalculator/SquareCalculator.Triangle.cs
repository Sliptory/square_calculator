namespace SquareCalc;

public static partial class SquareCalculator
{
    public static class Triangle
    {
        public static double FromHerons(double a, double b, double c)
        {
            double p = (a + b + c) / 2f;

            if(a * a + b * b == c * c)
                return (p - a) * (p - b);
            
            if(a * a + c * c == b * b)
                return (p - a) * (p - c);
            
            if(c * c + b * b == a * a)
                return (p - c) * (p - b);
            
            return Math.Sqrt(p * (p - a) * (p - b) * (p -  c));
        }
    }
}