using MaternityWard.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MaternityWard.BL
{
    public class ManageShifts
    {
        private readonly string dateFormat = "dd/MM/yyyy HH:mm:ss";
        public bool AddShift(Shift shift)
        {
            if (!ShiftDAL.IsExist(shift.ShiftID))
            {
                ShiftDAL.AddShift(shift.ShiftID, shift.EmployeeID, shift.HourIn.ToString(dateFormat), shift.HourOut.ToString(dateFormat));
                ManageEmployees manage = new ManageEmployees();

                Employee employee = manage.GetEmployeeByID(shift.EmployeeID);
                EmployeeDal.UpdateEmployeeWorkHours(shift.EmployeeID, employee.WorkHours + (shift.HourOut - shift.HourIn).Hours);
                if (employee.IsHourlyPaid)
                {
                    HourlyPaidEmployee hourlyPaid = (HourlyPaidEmployee)employee;
                    EmployeeDal.UpdateEmployeePayment(shift.EmployeeID, hourlyPaid.HourlyPayment * employee.WorkHours);
                }
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
                        DateTime.ParseExact(dataRow.Field<string>("HourIn"), dateFormat, null),
                        DateTime.ParseExact(dataRow.Field<string>("HourOut"), dateFormat, null)));
                }
            }
            return shifts;
        }
        public int GetShiftsAmount()
        {
            DataTable dataTable = ShiftDAL.GetAllShifts();
            if (dataTable != null)
            {
                return dataTable.Rows.Count;
            }
            return 0;
        }
    }
}
