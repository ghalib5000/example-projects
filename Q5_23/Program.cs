using System;

namespace Q5_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3,pa,pb,pc,aa,ab,ac;
            Console.WriteLine("enter X1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter X2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y2:");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter X3:");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y3:");
            y3 = Convert.ToDouble(Console.ReadLine());
            pa = triangle.distance(x2, y2, x3, y3);
            pb = triangle.distance(x3, y3, x1, y1);
            pc = triangle.distance(x1, y1, x2, y2);
            aa = triangle.degrees(triangle.angle(pa, pb, pc));
            ab = triangle.degrees(triangle.angle(pb, pa, pc));
            ac = triangle.degrees(triangle.angle(pc, pb, pa));
            Console.WriteLine("angle 1 is {0}", Math.Round(aa, 2));
            Console.WriteLine("angle 2 is {0}", Math.Round(ab, 2));
            Console.WriteLine("angle 3 is {0}", Math.Round(ac, 2));
        }
    }
}
