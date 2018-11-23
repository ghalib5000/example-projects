using System;
using System.Collections.Generic;
using System.Text;

namespace Q6_29
{
    class cards
    {
        public static int cardnum(int i)
        {
            int card=0;
            card = i;
            return card;
        }
        public static int cardtype(int i)
        {
            int card= 0;
            card = i;

            return card;
        }
        public static string numfind(int card)
        {
            string num="";
            if (card == 1)
            {
                num = "Ace";
            }
            else if (card == 13)
            {
                num = "King";
            }
            else if (card == 12)
            {
                num = "Queen";
            }
            else if (card == 11)
            {
                num = "Joker";
            }
            else
            {
                num = Convert.ToString(card);
            }
                return num;
        }
        public static string typefind(int card)
        {
            string num = "";
            if (card == 1)
            {
                num = "Spades";
            }
            else if (card == 2)
            {
                num = "Hearts";
            }
            else if (card == 3)
            {
                num = "Clubs";
            }
            else if (card == 4)
            {
                num = "Diamonds";
            }
            
            return num;
        }
    }
}
