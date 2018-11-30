using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_19
{
    class pattern
    {
        public static int randnum(int row, int col)
        {
            Random r = new Random();
            int rand = r.Next(0, 9);
            return rand;
        }
        public static void checker1(int row, int col, int[,] mat)
        {

            int p1 = 0, i, j, n;
            for (n = 0; n < 10; n++)
            {
                for (i = 0; i < row; i++)
                {
                    for (j = 0; j < col; j++)
                    {
                        if (mat[i, j] == n)
                        {
                            p1++;
                        }
                        else
                        {
                            p1 = 0;
                        }
                        if (p1 == 4)
                        { //player O wins
                            Console.WriteLine("the common number is: " + n);
                            p1 = 0;
                        }
                    }
                    p1 = 0;
                }
            }
        }
        public static void checker2(int row, int col, int[,] mat)
        {
            int p1 = 0, i, j, n;
            for (n = 0; n < 10; n++)
            {
                for (i = 0; i < 3; i++)
                {
                    for (i = 0; i < col; i++)
                    {
                        for (j = 0; j < row; j++)
                        {
                            if (mat[j, i] == n)
                            {
                                p1++;
                            }
                            else
                            {
                                p1 = 0;
                            }
                            if (p1 == 4)
                            { //player O wins
                                Console.WriteLine("the common number is: " + n);
                                p1 = 0;
                            }
                        }
                        p1 = 0;
                    }
                }
            }
        }
        public static void checker3(int row, int col, int[,] mat)
        {              //we need 0,0 1,1 2,2 0,2 2,0

            int p1 = 0, i, j, n;
            for (n = 0; n < 10; n++)
            {
                for (i = 0; i < row; i++)
                {
                    for (j = col-1; j >= 0; j--)
                    {
                        if (mat[i, i] == n)
                        {
                            p1++;
                        }
                        else if (mat[j, j] == n)
                        {
                            p1++;
                        }
                        else if (mat[i, j] == n)
                        {
                            p1++;
                        }
                        else
                        {
                            p1 = 0;
                        }
                        if (p1 == 4)
                        { //player O wins
                            Console.WriteLine("the common number is: " + n);
                            p1 = 0;
                        }
                    }
                    p1 = 0;
                }
            }
        }
    }
}
