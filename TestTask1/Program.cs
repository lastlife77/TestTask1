using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Programm
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Введите координаты точки");
            int x0 = Convert.ToInt32(Console.ReadLine());
            int y0 = Convert.ToInt32(Console.ReadLine());
            Point point = new Point(x0, y0);

            Console.WriteLine("Введите координаты линии");
            Console.WriteLine("Введите координаты первой точки");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Line line = new Line(new Point(x1, y1), new Point(x2, y2));
            
            double[] ans = line.straightLineEquation();
            Console.WriteLine($"Уравнение прямой: {ans[0]}x + ({ans[1]}y) + ({ans[2]})");
            double distance = SystemOfAxes.findDistance(point, line);
            Console.WriteLine($"Расстояние от точки до прямой равно: {distance}");
            Console.ReadLine();
        }
    }
}
