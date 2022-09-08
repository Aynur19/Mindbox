using MathLibrary;
using MathLibrary.Figures;

using Xunit;

using Circle = MathLibrary.Figures.Circle;

namespace MathLibraryTests
{
    /// <summary>
    /// ����� ��� ������������ ���������� ������� ����� � ������������.
    /// </summary>
    public class MathsTests
    {
        /// <summary>
        /// ���� ��� �������� ���������� ������� ���������� ��������������� ����� ��������� ������.
        /// </summary>
        /// <param name="input">������.</param>
        /// <param name="expectedArea">��������� �������.</param>
        /// <param name="expectedIsCircle">��������� ��������, ��� ��� ���������� ��� ���.</param>
        [Theory]
        [MemberData(nameof(AreaTestData.GetCircleTestData), MemberType = typeof(AreaTestData))]
        public void CircleAreaTests(double input, double expectedArea, bool expectedIsCircle)
        {
            Circle figure = new(input);

            Assert.Equal(expectedArea, figure.Area);
            Assert.Equal(expectedIsCircle, figure.IsCircle);
        }

        /// <summary>
        /// ���� ��� �������� ���������� ������� ���������� ����� ��������� ������ (����� ���������� ����������).
        /// </summary>
        /// <param name="input">������.</param>
        /// <param name="expectedArea">��������� �������.</param>
        [Theory]
        [MemberData(nameof(AreaTestData.GetMathsCircleTestData), MemberType = typeof(AreaTestData))]
        public void FigureCircleAreaTests(double input, double expectedArea)
        {
            IAreaCalculatable figure = new Circle(input);

            Assert.Equal(expectedArea, figure.Area);
        }

        /// <summary>
        /// ���� ��� �������� ���������� ������� ���������� ����� ����������� ����� Maths.
        /// </summary>
        /// <param name="input">������.</param>
        /// <param name="expectedArea">��������� �������.</param>
        [Theory]
        [MemberData(nameof(AreaTestData.GetMathsCircleTestData), MemberType = typeof(AreaTestData))]
        public void MathCircleAreaTests(double input, double expectedArea)
        {
            var actual = Maths.GetFigureArea(input);

            Assert.Equal(expectedArea, actual);
        }



        /// <summary>
        /// ���� ��� �������� ���������� ������� ���������� ����� ��������� ������.
        /// </summary>
        /// <param name="input">������ �������� ������.</param>
        /// <param name="area">��������� �������.</param>
        /// <param name="isTriangle">��������� ��������, ��� ��� ����������� ��� ���.</param>
        /// <param name="isEquilateral">��������� ��������, ��� ��� �������������� ����������� ��� ���.</param>
        /// <param name="isRight">��������� ��������, ��� ��� ������������� ����������� ��� ���.</param>
        /// <param name="isIsosceles">��������� ��������, ��� ��� �������������� ����������� ��� ���.</param>
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


        /// <summary>
        /// ���� ��� �������� ���������� ������� ���������� ����� ��������� ������ (����� ���������� ����������).
        /// </summary>
        /// <param name="input">������ �������� ������.</param>
        /// <param name="expectedArea">��������� �������.</param>
        [Theory]
        [MemberData(nameof(AreaTestData.GetMathsTriangleAreaTestData), MemberType = typeof(AreaTestData))]
        public void FigureTriangleAreaTests(double[] input, double expectedArea, bool expectedIsRight)
        {
            IAreaCalculatable figure = new Triangle(input[0], input[1], input[2]);

            Assert.Equal(expectedArea, figure.Area);
        }


        /// <summary>
        /// ���� ��� �������� ���������� ������� ���������� ����� ����������� ����� Maths.
        /// </summary>
        /// <param name="input">������ �������� ������.</param>
        /// <param name="expectedArea">��������� �������.</param>
        /// <param name="expectedIsRight">��������� ��������, ��� ��� ������������� ����������� ��� ���.</param>
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