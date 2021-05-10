using System;
using System.Collections.Generic;

namespace SumConsecutives
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); 
            list = Data.data;
            Operation oper = new Operation();
            
           oper.SumConsecutives(list).ForEach(i=> { Console.WriteLine(i); });
        }
    }
}
