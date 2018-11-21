using System;

namespace Q5_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
              Console.WriteLine("enter point1 latitude: ");
              x1 = sphere.radians(Convert.ToDouble(Console.ReadLine()));
              Console.WriteLine("enter point1 longitude: ");
              y1 = sphere.radians(Convert.ToDouble(Console.ReadLine()));
              Console.WriteLine("enter point2 latitude: ");
              x2 = sphere.radians(Convert.ToDouble(Console.ReadLine()));
              Console.WriteLine("enter point1 longitude: ");
              y2 = sphere.radians(Convert.ToDouble(Console.ReadLine()));
            double ans = sphere.finder(x1, x2, y1, y2);
            Console.WriteLine("the distance between two points is: "+ans);
        }

    }
}
