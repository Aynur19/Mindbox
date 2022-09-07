using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Figures
{
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
                if(value < 0)
                {
                    radius = double.NaN;
                }
                else
                {
                    radius = value;
                }
            }
        }

        public double GetArea()
        {
            if (double.IsNaN(Radius))
            {
                return double.NaN;
            }

            return Math.PI * Radius * Radius;   
        }
    }
}
