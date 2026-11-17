using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class LinearEquation : Equation
    {
        private double a;
        private double b;

        public LinearEquation(double a, double b)
            : base(new double[] { a, b }, "Линейное уравнение")
        {
            this.a = a;
            this.b = b;
        }

        public override double[] Solve()
        {
            if (a == 0)
            {
                HasRealRoots = false;
                return Array.Empty<double>();
            }

            double x = -b / a;
            HasRealRoots = true;

            return new double[] { x };
        }

        public override string ToString()
        {
            return $"{a}x + ({b}) = 0";
        }
    }
}
