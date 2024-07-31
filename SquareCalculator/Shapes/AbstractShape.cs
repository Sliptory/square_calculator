namespace SquareCalc.Shapes;

internal abstract class AbstractShape
{
    protected double[] values;

    protected AbstractShape(params double[] doubles)
    {
        values = doubles;

        if(values.Length == 0 || IsExist() == false)
            throw new Exception("Shape is not exist");
    }
    public abstract double GetSquare();
    public abstract bool IsExist();
}