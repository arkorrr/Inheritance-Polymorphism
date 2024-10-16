using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Equation
{
    public abstract void Solve();
}

public class LinearEquation : Equation
{
    private double _a, _b;

    public LinearEquation(double a, double b)
    {
        _a = a;
        _b = b;
    }

    public override void Solve()
    {
        if (_a != 0)
        {
            double x = -_b / _a;
            Console.WriteLine($"Solution: x = {x}");
        }
        else
        {
            Console.WriteLine("No solution.");
        }
    }
}

public class QuadraticEquation : Equation
{
    private double _a, _b, _c;

    public QuadraticEquation(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public override void Solve()
    {
        double discriminant = _b * _b - 4 * _a * _c;
        if (discriminant > 0)
        {
            double x1 = (-_b + Math.Sqrt(discriminant)) / (2 * _a);
            double x2 = (-_b - Math.Sqrt(discriminant)) / (2 * _a);
            Console.WriteLine($"Solutions: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -_b / (2 * _a);
            Console.WriteLine($"Solution: x = {x}");
        }
        else
        {
            Console.WriteLine("No real solutions.");
        }
    }
}