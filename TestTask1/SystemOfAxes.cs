using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class SystemOfAxes
    {
        public static double findDistance(Point point, Line line)
        {
            //растояние от точки до прямой
            //distance = |a*x0+b*y0+c|/sqrt(a^2+b^2)
            int x0 = point.getX();
            int y0 = point.getY();
            double[] abc = line.straightLineEquation();
            //числитель
            double numerator = Math.Abs(abc[0] * x0 + abc[1] * y0 + abc[2]);
            //знаменатель
            double denominator = Math.Sqrt(Math.Pow(abc[0],2) + Math.Pow(abc[1],2));

            double distance = numerator / denominator;
            return distance;
        }

        
        
    }
}
