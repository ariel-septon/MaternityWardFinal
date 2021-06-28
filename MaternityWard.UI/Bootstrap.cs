using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.UI
{
    public class UIBootstrap
    {
        public static int employeeID = 25;
        public static int shiftID = 1;
        private readonly UIExecuter uiExecuter = new UIExecuter(employeeID, shiftID);
        public UIBootstrap()
        {
            uiExecuter.MainMenu();
        }
    }
}
