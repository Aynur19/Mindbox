using MathLibrary;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryTests
{
    internal class AreaTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator() => GetAreaTestData().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        IEnumerable<object[]> GetAreaTestData()
        {
            List<object[]> data = new List<object[]>
            {
                // Circle
                new object[] { -10.0, 0.0 },
                new object[] { -7.5, 0.0 },
                new object[] { -5, 0.0 },
                new object[] { -2.5, 0.0 },
                new object[] { 0.0, 0.0},
                new object[] { 2.5, 19.634954084936208 },
                new object[] { 5.0, 78.53981633974483 },
                new object[] { 7.5, 176.71458676442586 },
                new object[] { 10.0, 314.1592653589793 },
            };

            return data;
        }
    }
}
