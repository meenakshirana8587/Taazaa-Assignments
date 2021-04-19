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
        UserInputs ui = new UserInputs();
            




        //private int generateCategoryId()
        //{
        //    CategoryId = CategoryId + 1;
        //    return CategoryId;
        //}
        public static int CategoryId;

        //public static int generateCategoryId()
        //{
        //    CategoryId = CategoryId + 1;

        //    return CategoryId;
        //}

        

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







            Console.WriteLine(Categories.Count);
            
            
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
        

    }
}
