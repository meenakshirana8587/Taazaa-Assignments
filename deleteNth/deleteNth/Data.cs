using System;
using System.Collections.Generic;
using System.Text;

namespace deleteNth
{
    public class Data
    {
        
        public int DeleteTill { get; set; }


        public int[] items;
        public int[] getArray()
        {
            Console.WriteLine("Enter the length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            items = new int[length];
            for(int i=0; i<length; i++)
            {
                items[i] = Convert.ToInt32(Console.ReadLine());
            }
            return items;
                
        }




    }
}
