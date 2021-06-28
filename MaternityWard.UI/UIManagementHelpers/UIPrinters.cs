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
                Console.WriteLine("Please Choose option from the menu:");
                foreach (T menuOption in Enum.GetValues(typeof(T)))
                {
                    Print<string>(Convert.ToInt32(menuOption) + ") " + menuOption);
                }
                choice = uiReaders.GetUserChoice();
                return choice;

            } while (choice > 0);
        }

        public void Print<T>(T str)
        {
            Console.WriteLine(str);
        }

    }
}
