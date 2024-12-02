using FluentAssertions;
using ShapeAreaCalculator.Library;

namespace ShapeAreaCalculator.Tests;

public class TriangleTest
{
    [Fact]
    public void Can_create_new_triangle()
    {
        var triangle = new Triangle(4, 2, 3);

        triangle.FirstSide.Should().Be(4);
        triangle.SecondSide.Should().Be(2);
        triangle.ThirdSide.Should().Be(3);
    }

    [Fact]
    public void Create_triangle_with_invalid_side()
    {
        var act = () => new Triangle(-4, 2, 3);
        
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void Create_invalid_triangle()
    {
        var act = () => new Triangle(4, 2, 2);
        
        act.Should().Throw<ArgumentException>();
    }


    [Fact]
    public void Can_calculate_triangle_area()
    {
        var triangle = new Triangle(3, 4, 5);

        var area = triangle.GetArea();

        area.Should().Be(6);
    }

    [Fact]
    public void Can_define_right_triangle()
    {
        var triangle = new Triangle(3, 4, 5);

        var result = triangle.IsRightTriangle();

        result.Should().BeTrue();
    }

    [Fact]
    public void Can_define_non_right_triangle()
    {
        var triangle = new Triangle(3.2, 4.4, 5.6);

        var result = triangle.IsRightTriangle();

        result.Should().BeFalse();
    }
}
