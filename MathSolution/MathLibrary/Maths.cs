using MathLibrary.Figures;

namespace MathLibrary
{
    /// <summary>
    /// Класс математических операций с методами без определенных аргументов.
    /// </summary>
    public class Maths
    {
        /// <summary>
        /// Валидация значения.
        /// </summary>
        /// <param name="x">Значение, задаваемое при создании фигуры.</param>
        /// <returns>Возвращает Nan, если значение меньше нуля.</returns>
        public static double ValidPositive(double x)
        {
            if(x < 0)
            {
                return double.NaN;
            }

            return x;
        }

        /// <summary>
        /// Проверка того, что треугольник прямоугольный.
        /// </summary>
        /// <returns></returns>
        public static bool TriangleIsRight(double x, double y, double z)
        {
            return new Triangle(x, y, z).IsRight;
        }

        /// <summary>
        /// Получение площади фигуры.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double GetFigureArea(params double[] x)
        {
            if (x == null || x.Length <= 0 || IsHasNegative(x))
            {
                return double.NaN;
            }

            /// TODO: можно расиширять для других фигур
            switch (x.Length)
            {
                case 1:
                    return new Circle(x[0]).Area;
                case 3:
                    return new Triangle(x[0], x[1], x[2]).Area;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Проверка того, что значения негативные.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static bool IsHasNegative(params double[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}