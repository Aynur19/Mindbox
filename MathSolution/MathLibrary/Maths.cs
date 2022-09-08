using MathLibrary.Figures;

namespace MathLibrary
{
    public class Maths
    {
        public static double ValidPositive(double x)
        {
            if(x < 0)
            {
                return double.NaN;
            }

            return x;
        }

        public static bool TriangleIsRight(double x, double y, double z)
        {
            return new Triangle(x, y, z).IsRight;
        }

        public static double GetFigureArea(params double[] x)
        {
            if (x == null || x.Length <= 0 || IsHasNegative(x))
            {
                return double.NaN;
            }

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