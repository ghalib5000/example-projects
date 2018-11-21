using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_31
{
    class credit
    {
        public static bool startcheck(string num)
        {

            if ((num[0] == '4' || num[0] == '5'||num[0]=='6'||(num[0]+""+num[1]=="37"))&&(num.Length==13||num.Length==16) )
            {
                return true;
            }
            else
                return false;
        }
        public static int doublecheck(string num)
        {
            int i = 0, n = 0, n1 = 0, n2,main=0;
            string spliter = "";
            while (i<num.Length)
            {
                main= (Convert.ToInt32(num[i]) - 48) * 2;
                if(main < 10)
                    {
                    n = n + ((Convert.ToInt32(num[i]) - 48) * 2);
                }
                if (main >= 10&& main < 19)
                {
                    spliter = Convert.ToString(main);
                    n1 = spliter[0]-48;
                    n2 = spliter[1]-48;
                    n = n+ n1 + n2;
                }
                i += 2;
            }
            return n;
        }
        public static int oddcheck(string num)
        {
            int i = 1,n=0,main=0;

            while (i < num.Length)
            {
                main = (Convert.ToInt32(num[i]) - 48);
                n = n + main;
                i += 2;
            }
            return n;
        }
        public static string isvalid(int a,int b)
        {
            if((a+b)%10==0)
            {
                return "is valid";
            }
            else
                return "is not valid";
        }

    }
}
