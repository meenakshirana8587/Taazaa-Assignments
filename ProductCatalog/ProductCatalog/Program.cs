using System;

namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            
            



            ManageOperationsBasedOnInputs manage = new ManageOperationsBasedOnInputs();

            UserInputs ui = new UserInputs();
            int op = ui.selectAnOption();


            while (op == 1)
            {
                manage.categorySelected();
            }

            while(op == 2)
            {
                manage.productSelected();
            }


            


        }
    }
}
