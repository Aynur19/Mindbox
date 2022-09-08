// See https://aka.ms/new-console-template for more information
using MathLibrary;
using MathLibrary.Figures;

Console.WriteLine("Hello, World!");

double[] radiuses = new double[]
{
    -10.0, -7.5, -5, -2.5, 0.0, 2.5, 5.0, 7.5, 10.0, 
    double.NegativeInfinity, double.PositiveInfinity,
    double.NaN, double.MaxValue, double.MinValue,
};

foreach (double radius in radiuses)
{
    Console.WriteLine(Maths.GetFigureArea(radius));
}

foreach (double radius in radiuses)
{
    Console.WriteLine(new Circle(radius));
}


List<double[]> sides = new List<double[]>
{
    new double[] { -10.0, -7.5, -5 },
    new double[] { -7.5, -5, -2.5 },
    new double[] { -5, -2.5, 0 },
    new double[] { -2.5, 0.0, 2.5 },
    new double[] { 0.0, 2.5, 5 },
    new double[] { 2.5, 5.0, 7.5 },
    new double[] { 5.0, 5.5, 5.5 },
    new double[] { 3.0, 4.0, 5.0 },
    new double[] { 7.0, 7.0, 7.0 },
    new double[] { 7.0, 5.0, 7.0 },
    new double[] { 100.0, 50.0, 1.0 },

    new double[] { double.NegativeInfinity, 5.0, 7.5 },
    new double[] { double.PositiveInfinity, 5.0, 7.5 },
    new double[] { double.NaN, 5.0, 7.5 },
    new double[] { double.MaxValue, 5.0, 7.5 },
    new double[] { double.MinValue, 5.0, 7.5 },
    new double[] { double.NaN, double.NaN, double.NaN },
    new double[] { double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity },
    new double[] { double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity },
    new double[] { double.MinValue, double.MinValue, double.MinValue },

    new double[] { double.MaxValue, 10.0, double.MaxValue },
    new double[] { double.MaxValue, double.MaxValue, double.MaxValue },
};

foreach (double[] s in sides)
{
    Console.WriteLine(Maths.GetFigureArea(s));
}

foreach (double[] s in sides)
{
    Console.WriteLine(new Triangle(s[0], s[1], s[2]));
}