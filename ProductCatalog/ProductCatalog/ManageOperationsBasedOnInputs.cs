using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class ManageOperationsBasedOnInputs
    {
        UserInputs ui = new UserInputs();
        Operations operations = new Operations();


        public void categorySelected()
        {


           
                while(ui.selectAnOption() == 1)
                {
                int option1 = ui.selectInCategory();
                    if (option1 == 1)
                    {


                        operations.AddCategory();
                   



                    }

                    else if (option1 == 2)
                    {

                        operations.ListAllCategories();

                    }
                    else if (option1 == 3)
                    {

                        operations.DeleteCategory();


                    }
                    else if (option1 == 4)
                    {

                        operations.SearchCategory();

                    }

                    else if (option1 == 5)
                    {
                        operations.exitCategory();
                    }
                



            }


            




        }

    }
}

    

