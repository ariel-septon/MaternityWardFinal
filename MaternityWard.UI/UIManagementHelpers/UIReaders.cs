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
        public T GetUserInput<T>()
        {
            return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

        }

        public DateTime GetUserDateTime(int day, DateTime hourIn)
        {
            try
            {
                string[] userInput = GetUserInput<string>().Split(':');
                DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                    day, Convert.ToInt32(userInput[0]), Convert.ToInt32(userInput[1]), 0);
                if (hourIn != null)
                {
                    if (hourIn > dateTime)
                    {
                       dateTime = dateTime.AddDays(1);
                    }
                }
                return dateTime;
            } catch
            {
                throw new Exception("You entered wrong date.");
            }
        }
    }
}
