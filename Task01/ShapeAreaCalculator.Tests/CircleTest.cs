using FluentAssertions;
using ShapeAreaCalculator.Library;

namespace ShapeAreaCalculator.Tests;

public class CircleTest
{
    [Fact]
    public void Can_create_new_circle()
    {
        var circle = new Circle(4);

        circle.Radius.Should().Be(4);
    }

    [Fact]
    public void Create_invalid_circle()
    {
        var act = () => new Circle(0);
        
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void Can_calculate_circle_area()
    {
        var circle = new Circle(4);

        var area = circle.GetArea();

        area.Should().BeApproximately(50.265482, 0.000001);
    }
}
