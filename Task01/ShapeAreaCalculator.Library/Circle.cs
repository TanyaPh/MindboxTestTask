namespace ShapeAreaCalculator.Library;


public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentOutOfRangeException("Radius must be more then 0");
        Radius = radius;
    }

    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }
}
