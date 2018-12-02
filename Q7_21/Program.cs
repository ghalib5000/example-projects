using System;

namespace Q7_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] cities = new double[5, 2];
            double[] distances = new double[4];
            double n=0;
            int p;
            /* cities[0, 0] = 2.5;
             cities[0, 1] = 5;
             cities[1, 0] = 5.1;
             cities[1, 1] = 3;
             cities[2, 0] = 1;
             cities[2, 1] = 9;
             cities[3, 0] = 5.4;
             cities[3, 1] = 54;
             cities[4, 0] = 5.5;
             cities[4, 1] = 2.1;*/
            Console.Write("enter number of cities: ");
            p = int.Parse(Console.ReadLine());
            for(int i = 0; i < p; i++) { 
                    Console.Write("enter point X of city {0}: ",i);
                    cities[i, 0] = double.Parse(Console.ReadLine());
                Console.Write("enter point Y of city {0}: ", i);
                cities[i, 1] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < p; i++) {
                for (int j = 0; j < 1; j++) {//    x1            x2             y1              y2
                    distances[i] = city.distance(cities[i,j],cities[i+1,j],cities[i,j+1],cities[i+1,j+1]);
                }
            }
            n = city.minum(distances);
            for(int i=0;i<distances.Length;i++)
            {
                if(n==distances[i])
                {
                    Console.WriteLine("the central city is " + i);
                }
            }
            Console.WriteLine("with minimum distance of: "+n);
           //TODO
        }
    }
}
