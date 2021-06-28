using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.UI
{
    public class UIBootstrap
    {
        // Based on the InitializeEmployees.sql script, the latest employeeID is 24
        // Those fields represent the new ID's for each table.
        public static int employeeID = 25;
        public static int shiftID = 3;
        private readonly UIExecuter uiExecuter = new UIExecuter(employeeID, shiftID);
        public UIBootstrap()
        {

        }
        public void Start()
        {
            uiExecuter.MainMenu();
        }
    }
}
