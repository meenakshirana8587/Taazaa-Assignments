using System;
using System.Collections.Generic;

namespace SumConsecutives
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = Data.data;
            Operation oper = new Operation();
            foreach(var i in oper.SumConsecutives(list))
            {
                Console.WriteLine(i);
            }
            
           //oper.SumConsecutives(list).ForEach(i=> { Console.WriteLine(i); });
        }
    }
}
