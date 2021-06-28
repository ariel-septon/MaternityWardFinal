using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.UI
{
    public class UIReaders
    {
        public UIReaders()
        {

        }
        public int GetUserChoice()
        {
            return int.Parse(Console.ReadLine());
        }

    }
}
