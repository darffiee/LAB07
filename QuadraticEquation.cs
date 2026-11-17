using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class QuadraticEquation : Equation
    {
        private double a;
        private double b;
        private double c;

        public double Discriminant { get; private set; }

        public QuadraticEquation(double a, double b, double c)
            : base(new double[] { a, b, c }, "Квадратное уравнение")
        {
            if (a == 0)
            {
                throw new ArgumentException("Коэффициент a не должен быть равен нулю.");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double[] Solve()
        {
            Discriminant = b * b - 4 * a * c;

            if (Discriminant < 0)
            {
                HasRealRoots = false;
                return Array.Empty<double>();
            }

            if (Discriminant == 0)
            {
                HasRealRoots = true;

                double x = -b / (2 * a);

                return new double[] { x };
            }

            double x1 = (-b + Math.Sqrt(Discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(Discriminant)) / (2 * a);

            HasRealRoots = true;

            return new double[] { x1, x2 };
        }

        public override string ToString()
        {
            return $"{a}x^2 + ({b})x + ({c}) = 0";
        }
    }
}