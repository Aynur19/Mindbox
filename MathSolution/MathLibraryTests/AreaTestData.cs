using System.Collections.Generic;

namespace MathLibraryTests
{
    internal class AreaTestData
    {
        public static IEnumerable<object[]> GetCircleAreaTestData()
        {
            yield return new object[] { -10.0, double.NaN }; 
            yield return new object[] { -7.5, double.NaN };
            yield return new object[] { -5, double.NaN };
            yield return new object[] { -2.5, double.NaN };
            yield return new object[] { 0.0, 0.0 };
            yield return new object[] { 2.5, 19.634954084936208 };
            yield return new object[] { 5.0, 78.53981633974483 };
            yield return new object[] { 7.5, 176.71458676442586 };
            yield return new object[] { 10.0, 314.1592653589793 };
        }
    }
}
