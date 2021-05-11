using System;
using System.Collections.Generic;
using System.Text;

namespace SumConsecutives
{
    public class Operation
    {
       public static  List<int> resultList = new List<int>();
        public List<int> SumConsecutives(List<int> list)
        {
            
            int i = 0;
            int sum = 0;
            //Console.WriteLine(list.Count);
            while (i < list.Count-1)
            {
                

                if (list[i] == list[i + 1])
                {
                    sum = sum + list[i];

                }
                else
                {
                    resultList.Add(sum+list[i]);
                    sum = 0;
                }
                
               
                
                i++;

            }
            return resultList;
                    
        }

    }
}
