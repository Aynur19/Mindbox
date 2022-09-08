using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    /// <summary>
    /// Интерфейс для вычисления площади.
    /// </summary>
    public interface IAreaCalculatable
    {
        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns>
        /// Возвращает площадь фигуры, если фигура выпуклая.
        /// Иначе возвращает NaN.
        /// </returns>
        double Area { get; }
    }
}
