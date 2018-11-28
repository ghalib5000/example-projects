using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_9
{
    class tic
    {
        public static void tac(char[,] game)
        {
            Console.WriteLine("-------------");
            Console.Write("|");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + game[i, j] + " |");
                }
                Console.WriteLine("");
                Console.Write("-------------");
                Console.WriteLine("");
                Console.Write("|");
            }
        }
        public static void valcheck(char[,] game, int row, int col, char c)
        {
            if (game[row, col] == 0)
            {
                game[row, col] = c;
            }
            else
            {
                Console.WriteLine("you tried to overwrite the older value which resulted in your turn being missed");
            }
        }
        public static int checker1(char[,] game)
        {
            int turns = 0;
            int p1 = 0, p2 = 0, i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (game[i, j] == 'O')
                    {
                        p1++;
                    }
                    else if (game[i, j] == 'X')
                    {
                        p2++;
                    }
                    if (p1 == 3)
                    { //player O wins
                        Console.WriteLine("player 1 wins");
                        turns = 15;
                        return turns;
                    }
                    else if (p2 == 3)
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
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (game[j, i] == 'O')
                    {
                        p1++;
                    }
                    else if (game[j, i] == 'X')
                    {
                        p2++;
                    }
                    if (p1 == 3)
                    { //player O wins
                        Console.WriteLine("player 1 wins");
                        turns = 15;
                        return turns;
                    }
                    else if (p2 == 3)
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
            int p1 = 0, p2 = 0, i, j;
            for (i = 0; i < 3; i++)
            {
                    if (game[i, i] == 'O')
                    {
                        p1++;
                    }
                    else if (game[i, i] == 'X')
                    {
                        p2++;
                    }
                    else if(i==0)
                    {
                    p1 = 0;
                    p2 = 0;
                        if(game[i,2]=='O')
                        {
                            p1++;
                        }
                        else if (game[i, 2] == 'X')
                        {
                            p2++;
                        }
                        else if (game[2, i] == 'O')
                        {
                            p1++;
                        }
                        else if (game[2, i] == 'X')
                        {
                            p2++;
                        }
                    }
                    if (p1 == 3)
                    { //player O wins
                        Console.WriteLine("player 1 wins");
                        turns = 15;
                        return turns;
                    }
                    else if (p2 == 3)
                    {
                        //player X wins
                        Console.WriteLine("player 2 wins");
                        turns = 15;
                        return turns;
                    }
            }
            return turns;
        } 
    }
}
