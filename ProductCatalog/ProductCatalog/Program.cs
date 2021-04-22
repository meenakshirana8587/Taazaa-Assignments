using System;

namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            
            



            ManageOperationsBasedOnInputs manage = new ManageOperationsBasedOnInputs();

            UserInputs ui = new UserInputs();
            

            while (true)
            {
                int op = ui.selectAnOption();

                if (op == 1)
                {
                    manage.categorySelected();
                }

                else if(op == 2)
                {
                    manage.productSelected();
                }
                else if(op==3)
                {
                    Environment.Exit(1);//to exit the operation
                }
            }


            


        }
    }
}
