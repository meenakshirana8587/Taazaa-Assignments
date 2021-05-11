using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deleteNth
{
    public class DeleteNth
    {

        public List<int> resultArray;

        public List<int> deleteNth(int[] arr, int x)
        {
            resultArray = new List<int>();

            foreach (var n in arr)
            {
                if (resultArray.Count(i => i == n) < x)
                {
                    resultArray.Add(n);
                }
            }
           resultArray.ForEach(i => Console.WriteLine(i));
            return resultArray;
        }
    }
}
