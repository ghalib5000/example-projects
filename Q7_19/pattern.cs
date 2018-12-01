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
                            j = j - p1;
                            p1 = 0;
                        }
                        if (p1 == 4)
                        {
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
                            {
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
        {
            int p1 = 0, i, j, n;
            if (row > col||row==col)
            {
                for (n = 0; n < 10; n++)
                {
                    for (j = 0; j < col; j++)
                    {
                        if (mat[j, j] == n)
                        {
                            p1++;
                        }
                    }
                    if (p1 == 4)
                    {
                        Console.WriteLine("the common number is: " + n);
                        p1 = 0;
                    }
                    j = 0;
                    p1 = 0;
                }
            }
            else if(row < col)
            {
                for (n = 0; n < 10; n++)
                {
                    for (i = 0; i < row; i++)
                    {
                        if (mat[i, i] == n)
                        {
                            p1++;
                        }
                    }
                    if (p1 == 4)
                    { //player O wins
                        Console.WriteLine("the common number is: " + n);
                        p1 = 0;
                    }
                    i = 0;
                    p1=0;
                }
            }
        }
        public static void checker4(int row, int col, int[,] mat)
        {
            int p = 0, n, o, i, j;
            for (o = 0; o < row; o++)
            {
                for (n = 0; n < 10; n++)
                {
                    j = col - 1;
                    i = o;
                    while (j >= 0 && i < row)
                    {
                        if (mat[i, j] == n)
                        {
                            i++;
                            p++;
                            j--;
                        }
                        else
                        {
                            i = i - p;
                            p = 0;
                            j = j + p - 1;
                        }
                        if (i == row)
                        {
                            j = -1;
                        }
                        if (p == 4)
                        {
                            Console.WriteLine("the common number is: " + n);
                            j = j + p - 1;
                            i = o;
                            p = 0;
                        }
                    }
                    p = 0;
                }
            }
        }
           /* else if (row < col)
            {
                while (i < row)
                {
                    for (n = 0; n < 10; n++)
                    {
                        j = 0;
                        for (i = row - 1; i >= 0; i--)
                        {
                            if (mat[i, j] == n)
                            {
                                p1++;
                            }
                            j++;
                        }
                        if (p1 == 4)
                        { //player O wins
                            Console.WriteLine("the common number is: " + n);
                            p1 = 0;
                        }
                        i = 0;
                        p1 = 0;
                    }
                    if(n==10)
                    {
                        n = 0;
                        i++;
                    }
                }
            }
        }*/
    }
}
