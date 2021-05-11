using System;

namespace deleteNth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DeleteNth delete = new DeleteNth();
            Data data = new Data();
            int [] arr = data.getArray();
            delete.deleteNth(arr, 2);
            
        }
    }
}
