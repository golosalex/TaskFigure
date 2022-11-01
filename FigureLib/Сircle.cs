using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            if (Radius < 0) throw new ArgumentException("отрицательный радиус невозможен");
        }

        public override double GetAreaOfFigure()
        {
            return Math.PI * Radius*Radius;
        }
    }
}
