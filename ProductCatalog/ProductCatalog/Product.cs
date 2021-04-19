using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string manufacturer { get; set; }
        public string ShortCode { get; set; }
        public ArrayList Categories;
        public string Description { get; set; }
        public int SellingPrice { get; set; }

        //public List<Category> Categories;


    }
}
