using System;
namespace Q7_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //PI = red , P2 = yellow;
            int row = 6, col = 7, t = 0;
            char[,] grid = new char[row, col];
            match.layout(grid);
            char p1 = 'R', p2 = 'Y';
            while (t < 10)
            {
                Console.WriteLine("Enter a column for red disk:");
                col = int.Parse(Console.ReadLine());
                col = match.randc();
                match.ifcond(grid, col, p1);
                match.layout(grid);
                t = match.checker1(grid); if (t == 15) { break; }
                t = match.checker2(grid); if (t == 15) { break; }
                t = match.checker3(grid); if (t == 15) { break; }
                t = match.checker4(grid); if (t == 15) { break; }
                t = match.checker4p2(grid); if (t == 15) { break; }

                Console.WriteLine("Enter a column for yellow disk:");
                col = int.Parse(Console.ReadLine());
                col = match.randc();
                match.ifcond(grid, col, p2);
                match.layout(grid);
                t = match.checker1(grid); if (t == 15) { break; }
                t = match.checker2(grid); if (t == 15) { break; }
                t = match.checker3(grid); if (t == 15) { break; }
                t = match.checker4(grid); if (t == 15) { break; }
                t = match.checker4p2(grid); if (t == 15) { break; }
            }
        }
    }
}
