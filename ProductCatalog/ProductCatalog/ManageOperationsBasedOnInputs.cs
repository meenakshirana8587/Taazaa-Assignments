using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class ManageOperationsBasedOnInputs
    {
        UserInputs ui = new UserInputs();
        

        public void categorySelected(Category category)
        {
            while(ui.selectAnOption()==1)
            {
               

                    if (ui.selectInCategory() == 1)
                    {

                    Operations operations = new Operations();
                    operations.AddCategory(category);
                        
                    }
                    else if (ui.selectInCategory() == 2)
                    {
                    Operations operations = new Operations();
                    operations.ListAllCategories();
                    }
                    else if (ui.selectInCategory() == 3)
                    {
                    Operations operations = new Operations();
                    operations.DeleteCategory();

                    }
                    else if (ui.selectInCategory() == 4)
                    {
                    Operations operations = new Operations();
                    operations.SearchCategory();
                    }
                }
           

            }

        }

    }

