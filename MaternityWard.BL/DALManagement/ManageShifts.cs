using MaternityWard.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MaternityWard.BL
{
    public class ManageShifts
    {
        private string dateFormat = "dd/MM/yyyy HH:mm:ss";
        public bool AddShift(Shift shift)
        {
            if (!ShiftDAL.IsExist(shift.ShiftID))
            {
                Console.WriteLine(shift.HourIn.ToString(dateFormat));
                ShiftDAL.AddShift(shift.ShiftID, shift.EmployeeID, shift.HourIn.ToString(dateFormat), shift.HourOut.ToString(dateFormat));
                ManageEmployees manage = new ManageEmployees();

                Employee employee = manage.GetEmployeeByID(shift.EmployeeID);
                EmployeeDal.UpdateEmployeeWorkHours(shift.EmployeeID, employee.WorkHours + (shift.HourOut - shift.HourIn).Hours);
                
                Console.WriteLine(employee.HourlyPayment);
                EmployeeDal.UpdateEmployeePayment(shift.EmployeeID, employee.HourlyPayment * employee.WorkHours);
                
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
                        DateTime.ParseExact(dataRow.Field<string>("HourIn"), dateFormat, null),
                        DateTime.ParseExact(dataRow.Field<string>("HourOut"), dateFormat, null)));
                }
            }
            return shifts;
        }
    }
}
