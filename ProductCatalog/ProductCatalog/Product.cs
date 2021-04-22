using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class Product: Store
    {
        //public int Id { get; set; }
        // public string Name { get; set; }
        public string Manufacturer { get; set; } = "";
        //public string ShortCode { get; set; }
        public List<Category> Categories;
        //public string Description { get; set; }
        public int SellingPrice { get; set; } = 0;
        public static int proId;
        public Product()
        {
            proId = proId + 1;
            this.Id = proId;

        }


    }
}
