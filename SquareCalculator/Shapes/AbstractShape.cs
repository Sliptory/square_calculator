namespace SquareCalc.Shapes;

internal abstract class AbstractShape
{
    protected double[] values;

    protected AbstractShape(params double[] doubles)
    {
        values = doubles;

        if(IsExist() == false)
            throw new Exception("Error: Shape is not exist");
    }
    public abstract double GetSquare();
    public abstract bool IsExist();
}