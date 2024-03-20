namespace SquareCalc;

public static partial class SquareCalculator
{
    public static double Calculate(params double[] values)
    {
        if(values.Length == 0)
            throw new Exception("SquareCalculator.Calculate: values.Length == 0");
        
        // тут мы делаем упрощение что площадь круга вычисляется только по радиусу
        // а треугольника, по трем сторонам
        switch(values.Length)
        {
            case 1:
                return Circle.FromRadius(values[0]);
            case 3:
                return Triangle.FromHerons(values[0], values[1], values[2]);
        }

        throw new Exception("SquareCalculator.Calculate: No method for processing values");
    }
}