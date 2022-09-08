namespace MathLibrary.Figures
{
    /// <summary>
    /// Окружность.
    /// </summary>
    public class Circle : IAreaCalculatable
    {
        public Circle(double r)
        {
            Radius = r;
        }

        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                radius = Maths.ValidPositive(value);
                UpdateProperties();
            }
        }

        public double Area { get; private set; }
        public bool IsCircle { get; private set; }

        /// <summary>
        /// Обновление свойств.
        /// </summary>
        private void UpdateProperties()
        {
            if (double.IsNaN(Radius))
            {
                IsCircle = false;
                Area = double.NaN;
                return;
            }

            Area = Math.PI * Radius * Radius;

            if (Area <= 0)
            {
                IsCircle = false;
            }
            else
            {
                IsCircle = true;
            }
        }
    }
}
