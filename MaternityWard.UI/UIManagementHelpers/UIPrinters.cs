using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.UI
{
    class UIPrinters
    {
        public UIPrinters()
        {
        }
        public int PrintMenuOptions<T>(UIReaders uiReaders) where T: System.Enum
        {
            int choice;
            do
            {
                PrintWithConsole<string>("Please Choose option from the menu:");
                foreach (T menuOption in Enum.GetValues(typeof(T)))
                {
                    PrintWithConsole<string>(Convert.ToInt32(menuOption) + ") " + menuOption);
                }
                choice = uiReaders.GetUserInput<int>();
            } while (choice != 0 && choice >= Enum.GetNames(typeof(T)).Length);
            return choice;
        }

        public void PrintWithConsole<T>(T print)
        {
            Console.WriteLine(print);
        }
    }
}
