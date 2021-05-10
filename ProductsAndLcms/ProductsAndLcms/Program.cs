using System;
using System.Collections.Generic;

namespace ProductsAndLcms
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            int [,]arr = data.GetArray();
            ProductsAndLcm prodlcm = new ProductsAndLcm();
            Console.WriteLine("result is : "+ prodlcm.result(arr));
            




        }
    }
}
