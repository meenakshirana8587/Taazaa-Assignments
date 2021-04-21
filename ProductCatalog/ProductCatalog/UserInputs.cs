using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{

    public class UserInputs
    {
        public int selectAnOption()
        {

            Console.WriteLine("Please Select An Option");
            Console.Write("1. Category \t");
            Console.Write("2. Product \t");
            Console.WriteLine("3.Exit Application");
            Console.WriteLine(" ");

            Console.WriteLine("Enter a number from above menu");
            Console.WriteLine(" ");
            int value = Convert.ToInt32(Console.ReadLine());
            if(value<1 || value>3)
            {
                Console.WriteLine("Please choose a valid operation");
              
            }
            return value;
            
        }

        public int selectInCategory()
        {
            Console.Write("1. Enter a Category \t");
            Console.Write("2. List all Categories \t");
            Console.Write("3. Delete a Category \t");
            Console.WriteLine("4. Search a category \t");
            
            Console.WriteLine("Enter a number from above menu");
            int value = Convert.ToInt32(Console.ReadLine());
            if(value<1 || value>4)
            {
                Console.WriteLine("Invalid Operation");
            }
            return value;
        }


        public int selectInProduct()
        {
            Console.Write("1. Enter a Product \t");
            Console.Write("2. List all Products \t");
            Console.Write("3. Delete a product \t");
            Console.WriteLine("4. Search a product \t");
           
            Console.WriteLine("Enter a number from above menu");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value < 1 || value > 4)
            {
                Console.WriteLine("Invalid Operation");
            }
            return value;
        }






    }
}
