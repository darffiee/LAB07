using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class Equation
    {
        public double[] Coefficients { get; protected set; }
        public string EquationType { get; protected set; }
        public bool HasRealRoots { get; protected set; }

        public Equation(double[] coefficients, string equationType)
        {
            Coefficients = coefficients;
            EquationType = equationType;
            HasRealRoots = false;
        }

        public virtual double[] Solve()
        {
            return Array.Empty<double>();
        }

        public virtual bool HasRootsInRange(double a, double b)
        {
            double[] roots = Solve();

            foreach (double root in roots)
            {
                if (root >= a && root <= b)
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return EquationType;
        }
    }
}
