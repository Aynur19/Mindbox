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
                    radius = 0;
                }
                else
                {
                    radius = value;
                }
            }
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;   
        }
    }
}
