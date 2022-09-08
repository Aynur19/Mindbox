using System.Collections.Generic;

namespace MathLibraryTests
{
    internal class AreaTestData
    {
        public static IEnumerable<object[]> GetCircleAreaTestData()
        {
            yield return new object[] { new double[] { -10.0 }, double.NaN }; 
            yield return new object[] { new double[] { -7.5 },  double.NaN };
            yield return new object[] { new double[] { -5 },    double.NaN };
            yield return new object[] { new double[] { -2.5 },  double.NaN };
            yield return new object[] { new double[] { 0.0 },   0.0 };
            yield return new object[] { new double[] { 2.5 },   19.634954084936208 };
            yield return new object[] { new double[] { 5.0 },   78.53981633974483 };
            yield return new object[] { new double[] { 7.5 },   176.71458676442586 };
            yield return new object[] { new double[] { 10.0 },  314.1592653589793 };
        }

        public static IEnumerable<object[]> GetTriangleTestData()
        {
            //                                          [x, y, z], Area, IsTriangle, IsEquilateral, IsRight, IsIsosceles
            yield return new object[] { new double[] { -10.0, -7.5, -5 },   double.NaN, false, false, false, false };
            yield return new object[] { new double[] { -7.5, -5, -2.5 },    double.NaN, false, false, false, false };
            yield return new object[] { new double[] { -5, -2.5, 0 },       double.NaN, false, false, false, false };
            yield return new object[] { new double[] { -2.5, 0.0, 2.5 },    double.NaN, false, false, false, false };
            yield return new object[] { new double[] { 0.0, 2.5, 5 },       double.NaN, false, false, false, false };
            yield return new object[] { new double[] { 2.5, 5.0, 7.5 },     double.NaN, false, false, false, false };
            yield return new object[] { new double[] { 5.0, 5.5, 5.5 },     12.24744871391589, true, false, false, true };
            yield return new object[] { new double[] { 3.0, 4.0, 5.0 },     6, true, false, true, false };
            yield return new object[] { new double[] { 7.0, 7.0, 7.0 },     21.21762239271875, true, true, false, true };
            yield return new object[] { new double[] { 7.0, 5.0, 7.0 },     16.345871038277526, true, false, false, true };
            yield return new object[] { new double[] { 100.0, 50.0, 1.0 },  double.NaN, false, false, false, false };

            yield return new object[] { new double[] { double.NegativeInfinity, 5.0, 7.5 }, double.NaN, false, false, false, false };
            yield return new object[] { new double[] { double.PositiveInfinity, 5.0, 7.5 }, double.NaN, false, false, false, false };
            yield return new object[] { new double[] { double.NaN, 5.0, 7.5 }, double.NaN, false, false, false, false };
            yield return new object[] { new double[] { double.MaxValue, 5.0, 7.5 }, double.NaN, false, false, false, false };
            yield return new object[] { new double[] { double.MinValue, 5.0, 7.5 }, double.NaN, false, false, false, false };
            yield return new object[] { new double[] { double.NaN, double.NaN, double.NaN }, double.NaN, false, false, false, false };
            yield return new object[] { new double[] { double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity }, double.NaN, false, false, false, false };
            yield return new object[] { new double[] { double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity }, double.NaN, false, false, false, false };
            yield return new object[] { new double[] { double.MinValue, double.MinValue, double.MinValue }, double.NaN, false, false, false, false };
            
            yield return new object[] { new double[] { double.MaxValue, 10.0, double.MaxValue }, double.PositiveInfinity, true, false, true, true };
            yield return new object[] { new double[] { double.MaxValue, double.MaxValue, double.MaxValue }, double.PositiveInfinity, true, true, true, true };
        }

        public static IEnumerable<object[]> GetMathsTriangleAreaTestData()
        {
            //                                          [x, y, z], Area, IsTriangle, IsEquilateral, IsRight, IsIsosceles
            yield return new object[] { new double[] { -10.0, -7.5, -5 }, double.NaN, false };
            yield return new object[] { new double[] { -7.5, -5, -2.5 }, double.NaN, false };
            yield return new object[] { new double[] { -5, -2.5, 0 }, double.NaN, false };
            yield return new object[] { new double[] { -2.5, 0.0, 2.5 }, double.NaN, false };
            yield return new object[] { new double[] { 0.0, 2.5, 5 }, double.NaN, false };
            yield return new object[] { new double[] { 2.5, 5.0, 7.5 }, double.NaN, false };
            yield return new object[] { new double[] { 5.0, 5.5, 5.5 }, 12.24744871391589, false };
            yield return new object[] { new double[] { 3.0, 4.0, 5.0 }, 6, true };
            yield return new object[] { new double[] { 7.0, 7.0, 7.0 }, 21.21762239271875, false };
            yield return new object[] { new double[] { 7.0, 5.0, 7.0 }, 16.345871038277526, false };
            yield return new object[] { new double[] { 100.0, 50.0, 1.0 }, double.NaN, false };

            yield return new object[] { new double[] { double.NegativeInfinity, 5.0, 7.5 }, double.NaN, false };
            yield return new object[] { new double[] { double.PositiveInfinity, 5.0, 7.5 }, double.NaN, false };
            yield return new object[] { new double[] { double.NaN, 5.0, 7.5 }, double.NaN, false };
            yield return new object[] { new double[] { double.MaxValue, 5.0, 7.5 }, double.NaN, false };
            yield return new object[] { new double[] { double.MinValue, 5.0, 7.5 }, double.NaN, false };
            yield return new object[] { new double[] { double.NaN, double.NaN, double.NaN }, double.NaN, false };
            yield return new object[] { new double[] { double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity }, double.NaN, false };
            yield return new object[] { new double[] { double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity }, double.NaN, false };
            yield return new object[] { new double[] { double.MinValue, double.MinValue, double.MinValue }, double.NaN, false };

            yield return new object[] { new double[] { double.MaxValue, 10.0, double.MaxValue }, double.PositiveInfinity, true };
            yield return new object[] { new double[] { double.MaxValue, double.MaxValue, double.MaxValue }, double.PositiveInfinity, true };
        }
    }
}
