using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.UI
{
    public class UIBootstrap
    {
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
