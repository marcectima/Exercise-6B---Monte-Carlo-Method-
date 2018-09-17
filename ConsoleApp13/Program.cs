using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    struct Point
    {
        public double xPoint;
        public double yPoint;
        public Point(Random ran)
        {
            this.xPoint = ran.NextDouble();
            this.yPoint = ran.NextDouble();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Random ran = new Random();
            do
            {
                double count = 0.0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter a number");
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Try Again");
                    }
                } while (number < 0);
                if (number != 0)
                {
                    Point[] points = new Point[number];
                    for (int x = 0; x < points.Length; x++)
                    {
                        points[x] = new Point(ran);
                    }
                    for (int x = 0; x < points.Length; x++)
                    {
                        if (GetY(points[x]) <= 1)
                        {
                           count++;
                        }
                    }
                    if (number > 0)
                    {
                        double z= count / points.Length;
                        z *= 4;
                        Console.WriteLine($"{z}\n{Math.PI}\nDifference:{Math.Abs(z - Math.PI)}");
                    }
                    else
                    {
                        Console.WriteLine("Try Again");
                        Console.ReadKey();
                    }
                }
                Console.ReadLine();
            } while (number != 0);
        }
        public static double GetY(Point point)
        {
            double y = Math.Sqrt((Math.Pow(point.xPoint, 2) + Math.Pow(point.yPoint, 2)));
            return y;
        }
    }
}