using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductCatalog
{
    public class Store
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";
        public string ShortCode { get; set; } = "";
        public string Description { get; set; } = "";


    }
}
