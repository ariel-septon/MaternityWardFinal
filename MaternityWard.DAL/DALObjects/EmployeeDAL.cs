using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MaternityWard.DAL
{
    public class EmployeeDal
    {
        public static DataTable GetAllEmployees()
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }
            string sql = "SELECT * FROM Employees";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            DBHelper.CloseConnection();
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return dataTable;
        }

        public static DataTable GetEmployeesByType(string employeeType)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }
            string sql = "SELECT * FROM Employees WHERE EmployeeType= '" + employeeType + "'";
            DataTable dataTable = DBHelper.GetDataTable(sql);
            DBHelper.CloseConnection();
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return dataTable;
        }
        public static int AddEmployee(int id, string type, int category, int workHours, bool isHourlyPaid, double payment)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }
            string sql = "INSERT INTO Employees (EmployeeID, EmployeeType, CategoryID, WorkHours, IsHourlyPaid, Payment)" +
                " VALUES (" + id + ",'" + type + "','" + category + "','" + workHours + "'," + Convert.ToInt32(isHourlyPaid) + "," + payment +")";
            int num = DBHelper.WriteData(sql);
            DBHelper.CloseConnection();
            id = id++;
            if (num == -1)
            {
                throw new Exception("The Employee wasn't added successfully");
            }
            return id;
        }

        public static bool IsExist(int employeeID)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }
            string sql = "SELECT * FROM Employees WHERE EmployeeID =" + employeeID;
            DataTable dataTable = DBHelper.GetDataTable(sql);
            DBHelper.CloseConnection();
            return (dataTable.Rows.Count != 0);
        }

        public static DataTable GetEmployee(int employeeID)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }
            
            string sql = "SELECT * FROM Employees WHERE EmployeeID =" + employeeID;
            DataTable dataTable = DBHelper.GetDataTable(sql);
            DBHelper.CloseConnection();
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return dataTable;
        }

        public static int UpdateEmployeeWorkHours(int employeeID, int workHours)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }

            string sql = "UPDATE Employees SET WorkHours = " + workHours + " WHERE EmployeeID = " + employeeID;
            int num = DBHelper.WriteData(sql);

            DBHelper.CloseConnection();
            if (num == -1)
            {
                throw new Exception("The employee work hours weren't updated successfully.");
            }
            return num;
        }

        public static int UpdateEmployeePayment(int employeeID, double payment)
        {
            if (!DBHelper.OpenConnection())
            {
                throw new Exception("There is a connection problem");
            }

            string sql = "UPDATE Employees SET Payment = " + payment + " WHERE EmployeeID = " + employeeID;
            int num = DBHelper.WriteData(sql);

            DBHelper.CloseConnection();
            if (num == -1)
            {
                throw new Exception("The employee payment wasn't updated successfully.");
            }
            return num;
        }
    }
}
