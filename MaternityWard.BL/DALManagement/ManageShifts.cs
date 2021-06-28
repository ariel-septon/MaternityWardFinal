using MaternityWard.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MaternityWard.BL
{
    public class ManageShifts
    {
        public bool AddShift(Shift shift)
        {
            if (!ShiftDAL.IsExist(shift.ShiftID))
            {
                ShiftDAL.AddShift(shift.ShiftID, shift.EmployeeID, shift.HourIn, shift.HourOut);
                EmployeeDal.UpdateEmployeeWorkHours(shift.EmployeeID, shift.HourOut - shift.HourIn);
               // EmployeeDal.UpdateEmployeePayment(shift.EmployeeID, )
                Console.WriteLine("success!");
                return true;
            }
            return false;
        }

        public List<Shift> GetShiftsByEmployeeID(int employeeID)
        {
            List<Shift> shifts = new List<Shift>();
            DataTable dataTable = ShiftDAL.GetShiftsByEmployeeID(employeeID);
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    shifts.Add(new Shift(
                        dataRow.Field<int>("ShiftID"),
                        dataRow.Field<int>("EmployeeID"),
                        dataRow.Field<int>("HourIn"),
                        dataRow.Field<int>("HourOut")));
                }
            }
            return shifts;
        }
    }
}
