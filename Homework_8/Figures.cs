using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    //----------------------------Task 1-------------------------------
    public abstract class Figure
    {
        public abstract double SquareCalculation(double a, double b);
    }
    public class Triangle : Figure
    {
        public override double SquareCalculation(double a, double h)
        {
            double s = (a * h) / 2;
            double p = a + a + a;
            Console.WriteLine($"Square = {s}, Perimeter = {p}");
            return p;
        }
    }
    public class Rectangle : Figure
    {
        public override double SquareCalculation(double a, double b)
        {
            double s = a * b;
            double p = 2 * (a + b);
            Console.WriteLine($"Square = {s}, Perimeter = {p}");
            return p;
        }
    }
    public class Circle : Figure
    {
        public override double SquareCalculation(double r, double pi)
        {
            double s = pi * (r * r);
            double p = 2 * pi * r;
            Console.WriteLine($"Square = {s}, Perimeter = {p}");
            return p;
        }
    }

}
