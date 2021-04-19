using System;

namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            



            ManageOperationsBasedOnInputs manage = new ManageOperationsBasedOnInputs();
            Category category = new Category();
            manage.categorySelected(category);
            


            


        }
    }
}
