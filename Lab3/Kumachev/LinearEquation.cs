using Lab.core;
using Lab2.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Lab3.Kumachev
{
    public class LinearEquation
    {
        protected List<float> x = new List<float>();
        public List<float> X => x.Select(r => r).ToList();

        public List<float> Solve(float a, float b)
        {
            if (a == 0)
                throw new NotAnEquationException("A = 0");

            x.Clear();
            x.Add(-b / a);
            return X;
        }
    }
}
