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
        public static List<string> allCode= new List<string>();
        public void AddCategory()
        {


            Category category = new Category();
               
                
            
            Console.WriteLine(" Id : " + category.Id + "\t");
            
            Console.WriteLine("Please enter category name: ");

            while (category.Name.Length < 1)
            {
                Console.WriteLine("name is a required field ");
                category.Name = Console.ReadLine();
            }
            
            
            Console.WriteLine("Please enter a Shortcode for the category(max 4 characters): ");
            while (category.ShortCode.Length < 1 || category.ShortCode.Length > 4)
            {
                Console.WriteLine("short code is a required field and must be max of 4 characters");
                category.ShortCode = Console.ReadLine();
            }
            Boolean check = true;
            while (check )
            {
               
                
                Boolean found = false;
                if (allCode.Count == 0)
                {
                    allCode.Add(category.ShortCode);
                    check = false;
                }
                else
                {



                    allCode.ForEach((e) => { if (e == category.ShortCode) { found = true; } });



                    //string result = allCode.First((string code) => code == category.ShortCode);
                    if (found == true)
                    {
                        Console.WriteLine("code already exist!! enter new");
                        allCode.Remove(category.ShortCode);
                        category.ShortCode = Console.ReadLine();

                    }
                    else
                    {
                        allCode.Add(category.ShortCode);
                        check = false;
                    }
                }
            }

           

            Console.WriteLine("Please enter description: ");
            while (category.Description.Length < 1)
            {
                Console.WriteLine("description is a required field ");
                category.Description = Console.ReadLine();
            }


            Categories.Add(category);







            //Console.WriteLine(Categories.Count);
            
            
        }

        public void ListAllCategories()
        {
            Console.WriteLine("Id\t\tName\t\tShortCode\t\tDescription");
            Console.WriteLine(" ");
            foreach(var item in Categories)
            {
                Console.WriteLine(item.Id + "\t\t" + item.Name + "\t\t" + item.ShortCode + "\t\t" + item.Description);
            }
        }

        public void DeleteCategory()
        {
            Console.WriteLine("Please select an option to delete");
            Console.Write("1. detete by Id\t");
            Console.WriteLine("2. delete by Short Code\t");
            Console.WriteLine(" ");

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter product id to delete the category");
                int id = Convert.ToInt32(Console.ReadLine());

                Categories.RemoveAt(id - 1);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter product short code to delete the category");
                string shortcode = Console.ReadLine();
                var categorytoremove = Categories.Single(r => r.ShortCode == shortcode);
                Categories.Remove(categorytoremove);
            }

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
       


        public void AddProduct()
        {


            Product product = new Product();



            Console.WriteLine(" Id : " + product.Id + "\t");

            Console.WriteLine("Please enter product name: ");

            while (product.Name.Length < 1)
            {
                Console.WriteLine("name is a required field ");
                product.Name = Console.ReadLine();
            }


            Console.WriteLine("Please enter a Shortcode for the product(max 4 characters): ");
            while (product.ShortCode.Length < 1 || product.ShortCode.Length > 4)
            {
                Console.WriteLine("short code is a required field and must be max of 4 characters");
                product.ShortCode = Console.ReadLine();
            }
            Boolean check = true;
            while (check)
            {


                Boolean found = false;
                if (allCode.Count == 0)
                {
                    allCode.Add(product.ShortCode);
                    check = false;
                }
                else
                {



                    allCode.ForEach((e) => { if (e == product.ShortCode) { found = true; } });



                    //string result = allCode.First((string code) => code == category.ShortCode);
                    if (found == true)
                    {
                        Console.WriteLine("code already exist!! enter new");
                        allCode.Remove(product.ShortCode);
                        product.ShortCode = Console.ReadLine();

                    }
                    else
                    {
                        allCode.Add(product.ShortCode);
                        check = false;
                    }
                }
            }

            Console.WriteLine("Please enter description: ");
            while (product.Description.Length < 1)
            {
                Console.WriteLine("description is a required field ");
                product.Description = Console.ReadLine();
            }


            Console.WriteLine("Please enter product manufacturer: ");
            while (product.Manufacturer.Length < 1)
            {
                Console.WriteLine("manufacturer is a required field ");
                product.Manufacturer = Console.ReadLine();
            }

            Console.WriteLine("Please enter product price: ");
            while (product.SellingPrice < 1)
            {
                Console.WriteLine("price must be  greater than 0 ");
                product.SellingPrice = Convert.ToInt32(Console.ReadLine());
            }


            product.Categories = new List<Category>();
            string choice;
            do
            {
                Console.WriteLine("Select Category By Id For Adding a Product");
                int id = Convert.ToInt32(Console.ReadLine());
                var data = Categories.Single((a) => a.Id == id);
                if (data != null)
                    product.Categories.Add(data);
                Console.WriteLine("Do you want to add more catagories, yes to continue otherwise no:");
                choice = Console.ReadLine();
            } while (choice == "yes");




            Products.Add(product);
        }
        public void ListAllProducts()
        {
            Console.WriteLine("Id\t\tName\t\tShortCode\t\tDescription\t\tManufacturer\t\tPrice\t\tCategories");
            Console.WriteLine(" ");
            Products.ForEach(item =>
            {
                string s = "";
                item.Categories.ForEach(c => {
                    s += c.Name + ", ";
                });
                Console.WriteLine(item.Id + "\t\t" + item.Name + "\t\t" + item.ShortCode + "\t\t\t" + item.Description + "\t\t\t" + item.Manufacturer + "\t\t\t" + item.SellingPrice + "\t\t" + s);

            }
            );
        }
        public void DeleteProduct()
        {
            Console.WriteLine("Please select an option to delete");
            Console.Write("1. delete by Id\t");
            Console.WriteLine("2. delete by Short Code\t");
            Console.WriteLine(" ");

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter product id to delete the product");
                int id = Convert.ToInt32(Console.ReadLine());

                Products.RemoveAt(id - 1);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter product short code to delete the product");
                string shortcode = Console.ReadLine();
                var producttoremove = Products.Single(r => r.ShortCode == shortcode);
                Products.Remove(producttoremove);
            }

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

        public void required(string s)
        {
            if(s==" ")
            {
                Console.WriteLine("this field is required");

            }
        }
        

    }
}
