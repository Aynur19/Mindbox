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
                PropertiesCalculation();
            }
        }

        public double Area { get; private set; }
        public bool IsCircle { get; private set; }


        private void PropertiesCalculation()
        {
            if (double.IsNaN(Radius))
            {
                IsCircle = false;
                Area = double.NaN;
            }

            IsCircle = true;
            Area = Math.PI * Radius * Radius;   
        }
    }
}
