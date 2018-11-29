using System;

namespace Q7_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            char[,] ch = new char[3, 3];
            int num;
            Console.Write("enter number between 0-511: ");
            num = int.Parse(Console.ReadLine());
            mat = convertor.dectobin(num);
            ch = convertor.numtochar(mat);
             for (int i = 0; i < 3; i++)
                {
                for (int j = 0; j < 3; j++)
                {
                 Console.Write(ch[i, j]+" ");
                }
                Console.WriteLine("");
                }
        }
    }
}
