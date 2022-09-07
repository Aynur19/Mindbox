using MathLibrary;
using MathLibrary.Figures;

using Xunit;

namespace MathLibraryTests
{
    public class MathsTests
    {
        [Theory]
        [ClassData(typeof(AreaTestData))]
        public void CircleAreaTests(double input, double expected)
        {
            IAreaCalculatable figure = new Circle(input);

            var actual = figure.GetArea();

            Assert.Equal(expected, actual);
        }
    }
}