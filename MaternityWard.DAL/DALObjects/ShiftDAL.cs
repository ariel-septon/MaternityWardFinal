using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MaternityWard.DAL
{
    public class ShiftDAL
    {
        public static DataTable GetAllShifts()
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }
            string sql = "SELECT * FROM Shifts";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            DBHelper.CloseConnection();
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return dataTable;
        }

        public static DataTable GetShiftsByEmployeeID(int employeeID)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }
            string sql = "SELECT * FROM Shifts WHERE EmployeeID= " + employeeID;
            DataTable dataTable = DBHelper.GetDataTable(sql);
            DBHelper.CloseConnection();
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return dataTable;
        }
        public static int AddShift(int shiftID, int employeeID, string hourIn, string hourOut)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }
            string sql = "INSERT INTO Shifts (ShiftID, EmployeeID, HourIn, HourOut)" +
                " VALUES (" + shiftID + "," + employeeID + ",'" + hourIn + "','" + hourOut + "')";

            int num = DBHelper.WriteData(sql);

            DBHelper.CloseConnection();
            shiftID = shiftID++;
            if (num == -1)
            {
                throw new Exception("The Shift wasn't added successfully");
            }
            return shiftID;
        }

        public static bool IsExist(int shiftID)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }
            string sql = "SELECT * FROM Shifts WHERE ShiftID =" + shiftID;
            DataTable dataTable = DBHelper.GetDataTable(sql);
            DBHelper.CloseConnection();
            return (dataTable.Rows.Count != 0);
        }

        public static DataTable GetShift(int shiftID)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }

            string sql = "SELECT * FROM Shifts WHERE ShiftID =" + shiftID + "'";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            DBHelper.CloseConnection();
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return dataTable;
        }

    }
}
