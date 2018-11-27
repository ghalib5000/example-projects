using System;

namespace Q7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,s2=0;
            int[,] days = new int[8,7] {{ 2, 4, 3, 4, 5, 8, 8 }, //34      0
                                         { 7, 3, 4, 3, 3, 4, 4 },//28      1
                                         { 3, 3, 4, 3, 3, 2, 2 },//20      2
                                         { 9, 3, 4, 7, 3, 4, 1 },//31      3
                                         { 3, 5, 4, 3, 6, 3, 8 },//32      4
                                         { 3, 4, 4, 6, 3, 4, 4 },//28      5
                                         { 3, 7, 4, 8, 3, 8, 4 },//37      6
                                         { 6, 3, 5, 9, 2, 7, 9 },//41      7
            };
            for (int i = 0; i < 8; i++)
            {
                sum = table.summer(days);
                Console.WriteLine(sum);
                sum = 0;
            }
            }
        }
}
