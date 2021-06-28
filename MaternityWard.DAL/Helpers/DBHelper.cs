using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MaternityWard.DAL
{
    public class DBHelper
    {
        private const int WRITEDATA_ERROR = -1;
        private static string connectionString = "Data Source=DESKTOP-27N9VU6;Initial Catalog=MaternityWard;Integrated Security=True";
        private static bool connectionOpen = false;
        public static SqlConnection dbConnection;
        public DBHelper()
        {

        }
        public static bool OpenConnection()
        {
           if (connectionOpen) { return true; }
           else
            {
                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
                connectionOpen = true;
                return true;
            }
        }
        public static void CloseConnection()
        {
            if (connectionOpen) {
                dbConnection.Close();
                connectionOpen = false; 
            }
        }
        public static bool IsConnectionOpen()
        {
            return connectionOpen;
        }
        public static SqlDataReader ReadData(string sql)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, dbConnection);
            SqlDataReader dataReader;
            try
            {
                dataReader = cmd.ExecuteReader();
                return dataReader;
            } catch (Exception) {
                return null;
            }
        }
        public static int WriteData(string sql)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, dbConnection);
            int affectedRows;
            try
            {
                affectedRows = cmd.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
            catch (InvalidOperationException)
            {
                CloseConnection();
                return WRITEDATA_ERROR;
            }
        }
        public static DataTable GetDataTable(string sql)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, dbConnection);
            SqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            if (dataReader != null)
            {
                dataTable.Load(dataReader);
                dbConnection.Close();
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                for(int j = 0; j < dataTable.Columns.Count; j++)
                {
                    DataColumn dataColumn = dataTable.Columns[j];
                }
            }
            return dataTable;
        }
        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }
}
