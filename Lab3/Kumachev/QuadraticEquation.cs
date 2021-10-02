using Lab2.Exceptions;
using System;
using System.Collections.Generic;

namespace Lab3.Kumachev
{
    public class QuadraticEquation : LinearEquation
    {
        protected float D(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }

        public override List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                base.Solve(a, b, c);
                return X;
            }

            float d = D(a, b, c);

            if (d < 0)
                throw new NegativeDescriminantException("D < 0");

            x.Clear();

            if (d == 0)
            {
                x.Add(-b / (2 * a));
            }
            else
            {
                d = (float)Math.Sqrt(d);

                x.Add((-b + d) / (2 * a));
                x.Add((-b - d) / (2 * a));
            }

            return X;
        }
    }
}
