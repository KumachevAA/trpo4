using Lab.core;
using Lab2.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Lab3.Kumachev
{
    public class LinearEquation : EquationInterface
    {
        protected List<float> x = new List<float>();
        public List<float> X => x.Select(r => r).ToList();

        public virtual List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
                throw new NotAnEquationException("A = 0");

            x.Clear();
            x.Add(-b / a);
            return X;
        }
    }
}
