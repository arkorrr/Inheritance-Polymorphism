using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class GeometricFigure
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Triangle : GeometricFigure
{
    private double _a, _b, _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public override double Area()
    {
        double s = Perimeter() / 2;
        return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
    }

    public override double Perimeter()
    {
        return _a + _b + _c;
    }
}

public class Circle : GeometricFigure
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * _radius;
    }
}

public class CompositeFigure
{
    private List<GeometricFigure> _figures = new List<GeometricFigure>();

    public void AddFigure(GeometricFigure figure)
    {
        _figures.Add(figure);
    }

    public double TotalArea()
    {
        double total = 0;
        foreach (var figure in _figures)
        {
            total += figure.Area();
        }
        return total;
    }
}
