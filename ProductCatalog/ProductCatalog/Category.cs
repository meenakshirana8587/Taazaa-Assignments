using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class Category: Store
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string ShortCode { get; set; }

        //public string Description { get; set; }

        public static int catId;
        public Category( )
        {
            catId = catId + 1;
            this.Id = catId;
            
        }
        
    }
}
