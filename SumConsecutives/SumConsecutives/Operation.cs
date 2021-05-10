using System;
using System.Collections.Generic;
using System.Text;

namespace SumConsecutives
{
    public class Operation
    {
        
        public List<int> SumConsecutives(List<int> list)
        {

            List<int> res = new List<int>();
            int data = list[0];
            int sum = 0;
            foreach (int i in list)
            {
                if (i == data)
                {
                    sum += data;
                }
                else
                {
                    res.Add(sum);
                    sum = data = i;
                }
            }
            res.Add(sum);
            return res;
        }

    }
}
