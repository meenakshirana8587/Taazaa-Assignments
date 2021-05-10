using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsAndLcms
{
    public class ProductsAndLcm
    {
        int sum = 0;
        
        
        public int result(int[,] arr)
        {
           

            for (int i = 0; i < (arr.Length)/2; i++)
            {
                int mul = 1;
                int lcm = 0, hcf = 0;
                int diff = 0, j = 0;




                mul = arr[i, 0] * arr[i, 1];
                //Console.WriteLine(mul);
                j = (arr[i, 0] < arr[i, 1]) ? arr[i, 0] : arr[i, 1];
                for (int k = 1; k <= j; k++)
                {
                    if (arr[i, 0] % k == 0 && arr[i, 1] % k == 0)
                    {
                        hcf = k;
                    }
                }
                //Console.WriteLine(hcf);
                lcm = mul / hcf;
                //Console.WriteLine(lcm);

                diff = mul - lcm;

                sum = sum + diff;

            }
            return sum;

        }


    }
}
