using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.UI
{
    class UIPrinters
    {
        UIReaders uiReaders = new UIReaders();
        public UIPrinters()
        {
        }

        public int PrintMenuOptions<T>() where T: System.Enum
        {
            int choice;
            do
            {
                PrintWithConsole<string>("Please Choose option from the menu:");
                foreach (T menuOption in Enum.GetValues(typeof(T)))
                {
                    PrintWithConsole<string>(Convert.ToInt32(menuOption) + ") " + menuOption);
                }
                choice = uiReaders.GetUserChoice();
                return choice;

            } while (choice > 0);
        }

        public void PrintWithConsole<T>(T print)
        {
            Console.WriteLine(print);
        }

    }
}
