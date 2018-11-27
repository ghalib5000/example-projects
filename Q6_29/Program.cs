using System;

namespace Q6_29
{
    class Program
    {
        static void Main(string[] args)
        {//SPADE = 1 HEART = 2 CLUBS = 3 DIAMONDS = 4
            int[] numdeck = new int[13];
            int[] typedeck = new int[4];
            int count = 0;
            int n1 = 1, n2 = 1, n3 = 1, n4 = 1;
            while (n1 <= 13)
            {
                for (; n2 <= 13; n2++)
                {
                    for (; n3 <= 13; n3++)
                    {
                        for (; n4 <= 13; n4++)
                        {
                            {
                                int n = n1 + n2 + n3 + n4;
                                if (n == 24)
                                {
                                    string c1 = cards.numfind(n1);
                                    string c2 = cards.numfind(n2);
                                    string c3 = cards.numfind(n3);
                                    string c4 = cards.numfind(n4);
                                    count++;
                                    Console.WriteLine("  " + c1 + " of spades," + c2 + " of hearts," + c3 + " of clubs," + n4 + " of diamonds:     " + n);
                                }
                            }
                        }
                        n4 = 1;
                    }
                    n4 = 1;
                    n3 = 1;
                }
                n1++;
                n2 = 1;
            }
            Console.WriteLine("the total ways of getting sum of 24 from 4 cards are" +
                ": " + count);
        }
    }
}
