namespace SquareCalc;

public static class SquareCalculator
{
    public static double GetSquare(params double[] values)
    { 
        // тут мы делаем упрощение что площадь круга вычисляется только по радиусу
        // а треугольника, по трем сторонам
        switch(values.Length)
        {
            case 0:
                throw new Exception("Error: please enter values");
            case 1:
                return new Shapes.Circle(values[0]).GetSquare();
            case 3:
                return new Shapes.Triangle(values[0], values[1], values[2]).GetSquare();
        }

        throw new Exception("Error: No method for processing values");
    }

    public static bool IsStraightTriangle(double a, double b, double c) => new Shapes.Triangle(a, b, c).IsStraight();
}