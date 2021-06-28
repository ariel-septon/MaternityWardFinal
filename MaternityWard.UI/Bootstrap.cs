using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.UI
{
    public class UIBootstrap
    {
        private readonly UIExecuter uiExecuter = new UIExecuter();
        public UIBootstrap()
        {

        }
        public void Start()
        {
            uiExecuter.MainMenu();
        }
    }
}
