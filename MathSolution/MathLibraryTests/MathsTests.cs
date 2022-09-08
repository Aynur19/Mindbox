using MathLibrary;
using MathLibrary.Figures;

using Xunit;

namespace MathLibraryTests
{
    public class MathsTests
    {
        [Theory]
        [MemberData(nameof(AreaTestData.GetCircleAreaTestData), MemberType = typeof(AreaTestData))]
        public void CircleAreaTests(double[] input, double expected)
        {
            IAreaCalculatable figure = new Circle(input[0]);

            var actual = figure.Area;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(AreaTestData.GetCircleAreaTestData), MemberType = typeof(AreaTestData))]
        public void MathCircleAreaTests(double[] input, double expected)
        {
            var actual = Maths.GetFigureArea(input);

            Assert.Equal(expected, actual);
        }



        [Theory]
        [MemberData(nameof(AreaTestData.GetTriangleTestData), MemberType = typeof(AreaTestData))]
        public void TriangleTests(double[] input, double area, bool isTriangle, bool isEquilateral, bool isRight,  bool isIsosceles)
        {
            Triangle triangle = new(input[0], input[1], input[2]);

            Assert.Equal(area, triangle.Area);
            Assert.Equal(isTriangle, triangle.IsTriangle);
            Assert.Equal(isEquilateral, triangle.IsEquilateral);
            Assert.Equal(isRight, triangle.IsRight);
            Assert.Equal(isIsosceles, triangle.IsIsosceles);
        }

        [Theory]
        [MemberData(nameof(AreaTestData.GetMathsTriangleAreaTestData), MemberType = typeof(AreaTestData))]
        public void MathTriangleAreaTests(double[] input, double expectedArea, bool expectedIsRight)
        {
            var area = Maths.GetFigureArea(input);
            var isRight = Maths.TriangleIsRight(input[0], input[1], input[2]);

            Assert.Equal(expectedArea, area);
            Assert.Equal(expectedIsRight, isRight);
        }
    }
}