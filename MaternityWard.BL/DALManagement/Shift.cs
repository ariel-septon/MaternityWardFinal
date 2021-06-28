namespace MaternityWard.BL
{
    public class Shift
    {
        private int shiftID;
        private int hourIn;
        private int hourOut;
        private int employeeID;
        public Shift(int shiftID, int employeeID, int hourIn, int hourOut)
        {
            this.shiftID = shiftID;
            this.employeeID = employeeID;
            this.hourIn = hourIn;
            this.hourOut = hourOut;
        }

        public int HourIn { get => hourIn; set => hourIn = value; }
        public int HourOut { get => hourOut; set => hourOut = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int ShiftID { get => shiftID; set => shiftID = value; }
    }
}
