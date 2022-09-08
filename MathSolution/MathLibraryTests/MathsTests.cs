using MathLibrary;
using MathLibrary.Figures;

using Xunit;

using Circle = MathLibrary.Figures.Circle;

namespace MathLibraryTests
{
    /// <summary>
    /// Класс для тестирования вычисления свойств круга и треугольника.
    /// </summary>
    public class MathsTests
    {
        /// <summary>
        /// Тест для проверки вычисления свойств окружности непосредственно через экземпляр класса.
        /// </summary>
        /// <param name="input">Радиус.</param>
        /// <param name="expectedArea">Ожидаемая площадь.</param>
        /// <param name="expectedIsCircle">Ожидаемое значение, что это окружность или нет.</param>
        [Theory]
        [MemberData(nameof(AreaTestData.GetCircleTestData), MemberType = typeof(AreaTestData))]
        public void CircleAreaTests(double input, double expectedArea, bool expectedIsCircle)
        {
            Circle figure = new(input);

            Assert.Equal(expectedArea, figure.Area);
            Assert.Equal(expectedIsCircle, figure.IsCircle);
        }

        /// <summary>
        /// Тест для проверки вычисления свойств окружности через экземпляр класса (через объявление интерфейса).
        /// </summary>
        /// <param name="input">Радиус.</param>
        /// <param name="expectedArea">Ожидаемая площадь.</param>
        [Theory]
        [MemberData(nameof(AreaTestData.GetMathsCircleTestData), MemberType = typeof(AreaTestData))]
        public void FigureCircleAreaTests(double input, double expectedArea)
        {
            IAreaCalculatable figure = new Circle(input);

            Assert.Equal(expectedArea, figure.Area);
        }

        /// <summary>
        /// Тест для проверки вычисления свойств окружности через статический класс Maths.
        /// </summary>
        /// <param name="input">Радиус.</param>
        /// <param name="expectedArea">Ожидаемая площадь.</param>
        [Theory]
        [MemberData(nameof(AreaTestData.GetMathsCircleTestData), MemberType = typeof(AreaTestData))]
        public void MathCircleAreaTests(double input, double expectedArea)
        {
            var actual = Maths.GetFigureArea(input);

            Assert.Equal(expectedArea, actual);
        }



        /// <summary>
        /// Тест для проверки вычисления свойств окружности через экземпляр класса.
        /// </summary>
        /// <param name="input">Массив значений сторон.</param>
        /// <param name="area">Ожидаемая площадь.</param>
        /// <param name="isTriangle">Ожидаемое значение, что это треугольник или нет.</param>
        /// <param name="isEquilateral">Ожидаемое значение, что это равносторонний треугольник или нет.</param>
        /// <param name="isRight">Ожидаемое значение, что это прямоугольный треугольник или нет.</param>
        /// <param name="isIsosceles">Ожидаемое значение, что это равнобедренный треугольник или нет.</param>
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
        /// Тест для проверки вычисления свойств окружности через экземпляр класса (через объявление интерфейса).
        /// </summary>
        /// <param name="input">Массив значений сторон.</param>
        /// <param name="expectedArea">Ожидаемая площадь.</param>
        [Theory]
        [MemberData(nameof(AreaTestData.GetMathsTriangleAreaTestData), MemberType = typeof(AreaTestData))]
        public void FigureTriangleAreaTests(double[] input, double expectedArea, bool expectedIsRight)
        {
            IAreaCalculatable figure = new Triangle(input[0], input[1], input[2]);

            Assert.Equal(expectedArea, figure.Area);
        }


        /// <summary>
        /// Тест для проверки вычисления свойств окружности через статический класс Maths.
        /// </summary>
        /// <param name="input">Массив значений сторон.</param>
        /// <param name="expectedArea">Ожидаемая площадь.</param>
        /// <param name="expectedIsRight">Ожидаемое значение, что это прямоугольный треугольник или нет.</param>
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