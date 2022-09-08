namespace MathLibrary.Figures
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IAreaCalculatable
    {
        public Triangle(double x)
        {
            SetSides(x, x, x);
        }

        public Triangle(double x, double y, double z)
        {
            SetSides(x, y, z);
        }

        private double sideX;
        public double SideX
        {
            get { return sideX; }
            private set { sideX = Maths.ValidPositive(value); }
        }
       
        
        private double sideY;
        public double SideY
        {
            get { return sideY; }
            private set { sideY = Maths.ValidPositive(value); }
        }

      
        private double sideZ;
        public double SideZ
        {
            get { return sideZ; }
            private set { sideZ = Maths.ValidPositive(value); }
        }

        public bool IsTriangle { get; private set; }
        public double Area { get; private set; }
        public bool IsEquilateral { get; private set; }
        public bool IsRight { get; private set; }
        public bool IsIsosceles { get; private set; }

        /// <summary>
        /// Проверка того, что есть сторона имеющая значение NaN.
        /// </summary>
        /// <returns></returns>
        private bool IsSidesHasNan()
        {
            if (double.IsNaN(SideX) || double.IsNaN(SideY) || double.IsNaN(SideZ))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Обновление свойств.
        /// </summary>
        public void UpdateProperties()
        {
            if (IsSidesHasNan())
            {
                SetInvalidTriangle();
            }
            else
            {
                SortSides(SideX, SideY, SideZ);

                double p = (SideX + SideY + sideZ) / 2;
                double area = p * (p - SideX) * (p - SideY) * (p - SideZ);

                if (area <= 0 || double.IsNaN(area))
                {
                    SetInvalidTriangle();
                }
                else
                {
                    IsTriangle = true;
                    Area = Math.Sqrt(area);
                
                    SetIsEquilateral();
                    SetIsIsRight();
                    SetIsIsosceles();
                }
            }
        }

        /// <summary>
        /// Сортировка сторон.
        /// </summary>
        private void SortSides(double x, double y, double z)
        {
            List<double> sides = new(new[] { x, y, z });
            sides.Sort();

            SideX = sides[0];
            SideY = sides[1];
            SideZ = sides[2];
        }

        /// <summary>
        /// Проверка того, что треугольник равносторонний.
        /// </summary>
        private void SetIsEquilateral()
        {
            if (SideX == SideY && SideY == SideZ)
            {
                IsEquilateral = true;
            }
            else
            {
                IsEquilateral = false;
            }
        }

        /// <summary>
        /// Проверка того, что треугольник прямоугольный.
        /// </summary>
        private void SetIsIsRight()
        {
            IsRight = SideZ * SideZ == (SideY * SideY) + (SideX * SideX);
        }

        /// <summary>
        /// Проверка того, что треугольник равнобедренный.
        /// </summary>
        private void SetIsIsosceles()
        {
            if (SideX == SideY || SideY == SideZ)
            {
                IsIsosceles = true;
            }
            else
            {
                IsIsosceles = false;
            }
        }

        /// <summary>
        /// Установка значений, когда фигура не треугольник.
        /// </summary>
        private void SetInvalidTriangle()
        {
            IsTriangle = false;
            Area = double.NaN;
            IsEquilateral = false;
            IsRight = false;
            IsIsosceles = false;
        }

        /// <summary>
        /// Обновление сторон.
        /// </summary>
        public void SetSides(double x, double y, double z)
        {
            SideX = x;
            SideY = y;
            SideZ = z;

            UpdateProperties();
        }


        public override string ToString()
        {
            return $"{nameof(Triangle)}:\n" +
                $"  {nameof(SideX)}: {SideX}\n" +
                $"  {nameof(SideY)}: {SideY}\n" +
                $"  {nameof(SideZ)}: {SideZ}\n" +
                $"  {nameof(Area)}: {Area}\n" +
                $"  {nameof(IsTriangle)}: {IsTriangle}\n" +
                $"  {nameof(IsEquilateral)}: {IsEquilateral}\n" +
                $"  {nameof(IsRight)}: {IsRight}\n" +
                $"  {nameof(IsIsosceles)}: {IsIsosceles}\n";
        }
    }
}
