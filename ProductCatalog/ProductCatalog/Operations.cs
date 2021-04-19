using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class Operations
    {
        public Category Category;
        public static List<Category> Categories= new List<Category>();





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

        

        public void AddCategory(Category category)
        {
            
            
           
            
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
            
        }

        public void DeleteCategory()
        {

        }

        public void SearchCategory()
        {

        }

        

    }
}
