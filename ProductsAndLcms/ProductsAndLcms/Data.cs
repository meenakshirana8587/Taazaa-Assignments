using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsAndLcms
{
    public class Data
    {
        public  int[,] GetArray()
        {
            Console.WriteLine("Please enter the total number of pairs");
            int length = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[length, 2];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("please enter pair(press enter before entering 2nd element of pair)");
                for (int j = 0; j < 2; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return array;
        }

    }
}
