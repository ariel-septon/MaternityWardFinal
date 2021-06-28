using System;
using System.Globalization;

namespace MaternityWard.BL
{
    public class Shift
    {
        private int shiftID;
        private DateTime hourIn;
        private DateTime hourOut;
        private int employeeID;
        public Shift(int shiftID, int employeeID, DateTime hourIn, DateTime hourOut)
        {
            this.shiftID = shiftID;
            this.employeeID = employeeID;
            this.hourIn = hourIn;
            this.hourOut = hourOut;
        }

        public DateTime HourIn { get => hourIn; set => hourIn = value; }
        public DateTime HourOut { get => hourOut; set => hourOut = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int ShiftID { get => shiftID; set => shiftID = value; }
    }
}
