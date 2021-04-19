using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductCatalog
{
    
    public class Operations
    {
        public Category Category;

        public static List<Category> Categories = new List<Category>();
        public static List<Product> Products = new List<Product>();
       
            




        
        

        

        

        public void AddCategory()
        {


            Category category = new Category();
               
                
            
            Console.WriteLine(" Id : " + category.Id + "\t");
            
            Console.WriteLine("Please enter category name: ");
            category.Name = Console.ReadLine();
            
            
            Console.WriteLine("Please enter a Shortcode for the category(max 4 characters): ");
            category.ShortCode = Console.ReadLine();
           
            Console.WriteLine("Please enter description: ");
            category.Description = Console.ReadLine();


            Categories.Add(category);







            //Console.WriteLine(Categories.Count);
            
            
        }

        public void ListAllCategories()
        {
            Console.WriteLine("Id\t\tName\t\tShortCode\t\tDescription");
            Console.WriteLine(" ");
            foreach(var item in Categories)
            {
                Console.WriteLine(item.Id + "\t\t" + item.Name + "\t\t" + item.ShortCode + "\t\t\t" + item.Description);
            }
        }

        public void DeleteCategory()
        {
            Console.WriteLine("Enter category id to delete the category");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Categories.RemoveAt(id-1);

        }

        public void SearchCategory()
        {
            Console.WriteLine("Please select an option to search");
            Console.Write("1. search by Id\t");
            Console.Write("2. search by Name\t");
            Console.WriteLine("3. search by ShortCode");
            Console.WriteLine(" ");

            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1)
            {
                Console.WriteLine("Enter Id");
                int id= Convert.ToInt32(Console.ReadLine());
                var res = Categories.Where(p => p.Id == id).ToList();
                Console.WriteLine(" ");
                res.ForEach(item => Console.WriteLine("Id: "+item.Id + "\t" + "Name: "+item.Name + "\t" + "ShortCode: "+item.ShortCode + "\t" + "Description: "+item.Description));
            }
            if (choice == 3)
            {
                Console.WriteLine("Enter ShortCode");
                string code = (Console.ReadLine().ToLower());
                var res = Categories.Where(p => p.ShortCode.ToLower() == code).ToList();
                Console.WriteLine(" ");
                res.ForEach(item => Console.WriteLine("Id: " + item.Id + "\t" + "Name: " + item.Name + "\t" + "ShortCode: " + item.ShortCode + "\t" + "Description: " + item.Description));
            }
            if (choice == 2)
            {
                Console.WriteLine("Enter name");
                string name = (Console.ReadLine().ToLower());
                var res = Categories.Where(p => p.Name.ToLower() == name).ToList();
                Console.WriteLine(" ");
                res.ForEach(item => Console.WriteLine("Id: " + item.Id + "\t" + "Name: " + item.Name + "\t" + "ShortCode: " + item.ShortCode + "\t" + "Description: " + item.Description));
            }


        }
        public void exitCategory()
        {
            
        }


        public void AddProduct()
        {


            Product product = new Product();



            Console.WriteLine(" Id : " + product.Id + "\t");

            Console.WriteLine("Please enter product name: ");
            product.Name = Console.ReadLine();


            Console.WriteLine("Please enter a Shortcode for the product(max 4 characters): ");
            product.ShortCode = Console.ReadLine();

            Console.WriteLine("Please enter description: ");
            product.Description = Console.ReadLine();


            Console.WriteLine("Please enter product manufacturer: ");
            product.Manufacturer = Console.ReadLine();

            Console.WriteLine("Please enter product price: ");
            product.SellingPrice = Convert.ToInt32(Console.ReadLine());


            Products.Add(product);







            


        }
        public void ListAllProducts()
        {
            Console.WriteLine("Id\t\tName\t\tShortCode\t\tDescription\t\tManufacturer\t\tPrice");
            Console.WriteLine(" ");
            foreach (var item in Products)
            {
                Console.WriteLine(item.Id + "\t\t" + item.Name + "\t\t" + item.ShortCode + "\t\t\t" + item.Description+ "\t\t"+ item.Manufacturer + "\t\t" + item.SellingPrice);
            }
        }
        public void DeleteProduct()
        {
            Console.WriteLine("Enter product id to delete the product");
            int id = Convert.ToInt32(Console.ReadLine());

            Products.RemoveAt(id - 1);

        }

        public void SearchProduct()
        {
            Console.WriteLine("Please select an option to search");
            Console.Write("1. search by Id\t");
            Console.Write("2. search by Name\t");
            Console.WriteLine("3. search by ShortCode");
            Console.WriteLine(" ");

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var res = Products.Where(p => p.Id == id).ToList();
                Console.WriteLine(" ");
                res.ForEach(item => Console.WriteLine("Id: " + item.Id + "\t" + "Name: " + item.Name + "\t" + "ShortCode: " + item.ShortCode + "\t" + "Description: " + item.Description + "Manufacturer: "+ item.Manufacturer + "Price: "+ item.SellingPrice));
            }
            if (choice == 3)
            {
                Console.WriteLine("Enter ShortCode");
                string code = (Console.ReadLine().ToLower());
                var res = Products.Where(p => p.ShortCode.ToLower() == code).ToList();
                Console.WriteLine(" ");
                res.ForEach(item => Console.WriteLine("Id: " + item.Id + "\t" + "Name: " + item.Name + "\t" + "ShortCode: " + item.ShortCode + "\t" + "Description: " + item.Description + "Manufacturer: " + item.Manufacturer + "Price: " + item.SellingPrice));
            }
            if (choice == 2)
            {
                Console.WriteLine("Enter name");
                string name = (Console.ReadLine().ToLower());
                var res = Products.Where(p => p.Name.ToLower() == name).ToList();
                Console.WriteLine(" ");
                res.ForEach(item => Console.WriteLine("Id: " + item.Id + "\t" + "Name: " + item.Name + "\t" + "ShortCode: " + item.ShortCode + "\t" + "Description: " + item.Description + "Manufacturer: " + item.Manufacturer + "Price: " + item.SellingPrice));
            }


        }
        public void exitProduct()
        {
           
        }

    }
}
