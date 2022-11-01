using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Triangle : Figure
    {
        public List<double> SidesOfATriangle { get; }

        public Triangle(double a,double b, double c)
        {
            SidesOfATriangle = new List<double>();
            SidesOfATriangle.Add(a);
            SidesOfATriangle.Add(b);
            SidesOfATriangle.Add(c);

            double perimetr = a + b + c;
            if (SidesOfATriangle.Any(side => side * 2 > perimetr))  throw new Exception("не соблюдено равенство треугольника");
            
        }

        public override double GetAreaOfFigure()
        {
            double p = SidesOfATriangle.Sum()/2;
            double s = Math.Sqrt(p * (p - SidesOfATriangle[0]) * (p - SidesOfATriangle[1]) * (p - SidesOfATriangle[2]));
            return s;
        }
        public bool IsSquerTriangle()
        {
            SidesOfATriangle.Sort();
            return  SidesOfATriangle[0] * SidesOfATriangle[0] + 
                    SidesOfATriangle[1] * SidesOfATriangle[1] - 
                    SidesOfATriangle[2] * SidesOfATriangle[2] < 0.001;
        }
    }
}
