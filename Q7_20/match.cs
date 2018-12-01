using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_20
{
    class match
    {
        public static int randc()
        {
            Random rand = new Random();
            int r;
            r = rand.Next(0, 6);
            
            return r;
        }
        public static void layout(char[,] game)
        {
            Console.WriteLine("--0---1---2---3---4---5---6---");
            Console.Write("|");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(" " + game[i, j] + " |");
                }
                Console.WriteLine("");
                Console.Write("------------------------------");
                Console.WriteLine("");
                Console.Write("|");
            }
        }
        public static void ifcond(char[,] grid, int col, char p1)
        {
            if (grid[5, col] == 0)
            {
                grid[5, col] = p1;
            }
            else if (grid[4, col] == 0)
            {
                grid[4, col] = p1;
            }
            else if (grid[3, col] == 0)
            {
                grid[3, col] = p1;
            }
            else if (grid[2, col] == 0)
            {
                grid[2, col] = p1;
            }
            else if (grid[1, col] == 0)
            {
                grid[1, col] = p1;
            }
            else if (grid[0, col] == 0)
            {
                grid[0, col] = p1;
            }
            else
            {
                Console.WriteLine("you tried to enter the disk at a column which was already filled");
            }

        }
        public static int checker1(char[,] game)
        {
            int turns = 0;
            int p1 = 0, p2 = 0, i, j;
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    if (game[i, j] == 'R')
                    {
                        p1++;
                        p2 = 0;
                    }
                    else if (game[i, j] == 'Y')
                    {
                        p1 = 0;
                        p2++;
                    }
                    else
                    {
                        p1 = 0;
                        p2 = 0;
                    }
                    if (p1 == 4)
                    { //player O wins
                        Console.WriteLine("player 1 wins");
                        turns = 15;
                        return turns;
                    }
                    else if (p2 == 4)
                    {
                        //player X wins
                        Console.WriteLine("player 2 wins");
                        turns = 15;
                        return turns;
                    }
                }
                p1 = 0;
                p2 = 0;
            }
            return turns;
        }
        public static int checker2(char[,] game)
        {
            int turns = 0;
            int p1 = 0, p2 = 0, i, j;
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    if (game[j, i] == 'R')
                    {
                        p1++;
                        p2 = 0;
                    }
                    else if (game[j, i] == 'Y')
                    {
                        p2++;
                        p1 = 0;
                    }
                    else
                    {
                        p1 = 0;
                        p2 = 0;
                    }
                    if (p1 == 4)
                    { //player O wins
                        Console.WriteLine("player 1 wins");
                        turns = 15;
                        return turns;
                    }
                    else if (p2 == 4)
                    {
                        //player X wins
                        Console.WriteLine("player 2 wins");
                        turns = 15;
                        return turns;
                    }
                }
                p1 = 0;
                p2 = 0;

            }
            return turns;
        }
        public static int checker3(char[,] game)
        {              //we need 0,0 1,1 2,2 0,2 2,0
            int turns = 0;
            int p1 = 0, p2 = 0, j, i = 0;

            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    if (game[j, i] == 'R')
                    {
                        p1++;
                        i++;
                    }
                    else{
                        p1 = 0;
                    }
                    if (j == 5)
                    {
                        if (game[j, 6] == 'R')
                        {
                            p1++;
                        }
                    }
                }
                if (p1 == 4)
                { //player O wins
                    Console.WriteLine("player 1 wins");
                    turns = 15;
                    return turns;
                }
                i = i - p1;
                p1 = 0;
            }
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    if (game[j, j] == 'Y')
                    {
                        p2++;
                        i++;
                    }
                    if (j == 5)
                    {
                        if (game[j, 6] == 'Y')
                        {
                            p2++;
                        }
                    }
                }
                if (p2 == 4)
                {
                    //player X wins
                    Console.WriteLine("player 2 wins");
                    turns = 15;
                    return turns;
                }
                i = i - p2;
                p2 = 0;
            }
            if (p1 == 4)
            { //player O wins
                Console.WriteLine("player 1 wins");
                turns = 15;
                return turns;
            }
            else if (p2 == 4)
            {
                //player X wins
                Console.WriteLine("player 2 wins");
                turns = 15;
                return turns;
            }
            return turns;
        }
        public static int checker4(char[,] game)
        {
            int p = 0, o, i, j, t = 0;
            char n = '0';
            for (o = 0; o < 5; o++)
            {
                n = 'R';
                j = 7 - 1;
                i = o;
                while (j >= 0 && i < 6)
                {
                    if (game[i, j] == n)
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
                    if (i == 5)
                    {
                        j = -1;
                    }
                    if (p == 4)
                    {
                        Console.WriteLine("PLayer 1 wins ");
                        j = j + p - 1;
                        i = o;
                        p = 0;
                        t = 15;
                        return t;
                    }
                }
                p = 0;
            }
            return t;
        }
        public static int checker4p2(char[,] game)
        {
            int p = 0, o, i, j, t = 0;
            char n = '0';
            for (o = 0; o < 5; o++)
            {
                n = 'Y';
                j = 7 - 1;
                i = o;
                while (j >= 0 && i < 6)
                {
                    if (game[i, j] == n)
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
                    if (i == 5)
                    {
                        j = -1;
                    }
                    if (p == 4)
                    {
                        Console.WriteLine("PLayer 2 wins ");
                        j = j + p - 1;
                        i = o;
                        p = 0;
                        t = 15;
                        return t;
                    }
                }
                p = 0;
            }
            return t;
        }

    }
}

