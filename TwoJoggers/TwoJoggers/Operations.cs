using System;
using System.Collections.Generic;
using System.Text;

namespace TwoJoggers
{
    public class Operations
    {
        public  Tuple<int, int> NbrOfLaps(int x, int y)
        {
             int  i, bob, charles, hcf=0;

            

            for (i = 1; i <= x || i <= y; i++)
            {
                if (x % i == 0 && y % i == 0)
                    hcf = i;
            }
            bob = y / hcf;
            charles = x / hcf;
            return new Tuple<int , int>(bob, charles);


        }
            

    }
}
