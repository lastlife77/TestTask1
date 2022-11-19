using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Line
    {
        Point startPoint;
        Point endPoint;

        public Line(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public Point getStartPoint()
        {
            return startPoint;
        }
        public Point getEndPoint()
        {
            return endPoint;
        }

        public double[] straightLineEquation()
        {
            //уравнение прямой 
            //ax +by + c = 0

            int x1 = startPoint.getX();
            int y1 = startPoint.getY();
            int x2 = endPoint.getX();
            int y2 = endPoint.getY();

            // (x-x1)/(x2-x1) = (y-y1)/(y2-y1)

            //(x-x1)/(y-y1) = (x2-x1)/(y2-y1)

            // пусть k = (x2-x1)/(y2-y1)
            double k;
            if (y2-y1 == 0)
            {
                k = 0;
            }
            else
            {
                k = (double)(x2 - x1) / (y2 - y1);
            }
            //(x-x1) = (y-y1)*k

            //(x-x1) = y*k - y1*k

            //x - y*k - x1 + y1*k = 0

            //x - y*k - (x1 - y1*k) = 0;

            double a = 1;
            double b = -k;
            double c = -(x1 - y1 * k);
            double[] ans = { a, b, c };
            return ans;
        }
    }
}
