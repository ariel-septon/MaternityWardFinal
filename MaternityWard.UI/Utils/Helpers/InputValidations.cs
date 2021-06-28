using MaternityWard.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.UI
{
    class InputValidations
    {
        public bool IsEmployeeIDValid(UIPrinters uiPrinters, Employee employee)
        {
            if (employee == null)
            {
                uiPrinters.PrintWithConsole<string>("You inserted an invalid employeeID.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DataValidCheck(UIPrinters uiPrinters, bool isAddedToDB)
        {
            if (isAddedToDB)
            {
                uiPrinters.PrintWithConsole<string>("Data was successfully added to DB!");
            } else
            {
                uiPrinters.PrintWithConsole<string>("The entered Data is invalid, Operation failed.");
            }
        }
    }
}
