using FluentAssertions;
using ShapeAreaCalculator.Library;

namespace ShapeAreaCalculator.Tests;

public class CalculatorTest
{
    [Fact]
    public void Can_calculate_triangle_area()
    {
        var triangle = new Triangle(3.2, 4.4, 5.6);

        var area = Calculator.CalculateArea(triangle);
        
        area.Should().BeApproximately(7.026237, 0.000001);
    }

    [Fact]
    public void Can_calculate_circle_area()
    {
        var circle = new Circle(4);

        var area = Calculator.CalculateArea(circle);
        
        area.Should().BeApproximately(50.265482, 0.000001);
    }
}
