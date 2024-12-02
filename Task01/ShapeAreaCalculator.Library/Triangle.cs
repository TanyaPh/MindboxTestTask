namespace ShapeAreaCalculator.Library;

public class Triangle : Shape
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }
    private double Perimeter => FirstSide + SecondSide + ThirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new ArgumentOutOfRangeException("Sides must be greater than 0");
        }

        if (firstSide + secondSide <= thirdSide || 
            firstSide + thirdSide <= secondSide || 
            secondSide + thirdSide <= firstSide)
        {
            throw new ArgumentException("Invalid sides for a triangle");
        }

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public override double GetArea()
    {
        var halfPerimeter = Perimeter / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * 
            (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
    }


    public bool IsRightTriangle()
    {
        if (FirstSide > SecondSide && FirstSide > ThirdSide) {
            return FirstSide * FirstSide == SecondSide * SecondSide + ThirdSide * ThirdSide;
        }
        if (SecondSide > FirstSide && SecondSide > ThirdSide) {
            return SecondSide * SecondSide == FirstSide * FirstSide + ThirdSide * ThirdSide;
        }

        return ThirdSide * ThirdSide == FirstSide * FirstSide + SecondSide * SecondSide;
    }
}
