using System;

namespace Q7_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int row, col, turns = 0, c=0;
            row = rand.Next(0, 2);
            col = rand.Next(0, 2);
            char[,] game = new char[3, 3];
            tic.tac(game);
            for (int u = 0; u < 3; u++)
            {
                for (int y = 0; y < 3; y++)
                {
                    while (game[u, y] == 0)

                    {
                       // row = rand.Next(0, 3);
                       // col = rand.Next(0, 3);
                              Console.WriteLine("Enter a row(0,1 or 2) for player 1:");
                              row = int.Parse(Console.ReadLine());
                              Console.WriteLine("Enter a column(0,1 or 2) for player 1:");
                              col = int.Parse(Console.ReadLine());
                        tic.valcheck(game, row, col, 'O');
                        tic.tac(game);
                        c = tic.checker1(game);
                        if (c == 15)
                        {
                            y = 5;
                            u = 5;
                            break; }
                        c = tic.checker2(game);
                        if (c == 15)
                        { y = 5; u = 5; break; }
                        c = tic.checker3(game);
                        if (c == 15)
                        { y = 5; u = 5; break; }
                        //PLAYER 2 HERE
                      //  row = rand.Next(0, 3);
                       // col = rand.Next(0, 3);
                          Console.WriteLine("Enter a row(0,1 or 2) for player 2:");
                          row = int.Parse(Console.ReadLine());
                          Console.WriteLine("Enter a column(0,1 or 2) for player 2:");
                          col = int.Parse(Console.ReadLine());
                        tic.valcheck(game, row, col, 'X');
                        tic.tac(game);
                        c = tic.checker1(game);
                        if (c == 15)
                        { y = 5; u = 5; break; }
                        c = tic.checker2(game);
                        if (c == 15)
                        { y = 5; u = 5; break; }
                        c = tic.checker3(game);
                        if (c == 15)
                        { y = 5; u = 5; break; }
                        turns++;
                    }
                }
            }
            if(c==0)
            { Console.WriteLine("it's a draw"); }
        }
    }
}
