using MaternityWard.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MaternityWard.BL
{
    public class ManageEmployees
    {
        public bool AddEmployee(Employee employee)
        {
            if (!EmployeeDal.IsExist(employee.Id))
            {
                EmployeeDal.AddEmployee(employee.Id, employee.EmployeeType.ToString(), (int)employee.Category, employee.WorkHours, employee.IsHourlyPaid, employee.Payment);
                return true;
            }
            return false;
        }

        public Employee GetEmployeeByID(int employeeID)
        {
            CreateEmployeeFactory employeeFactory = new CreateEmployeeFactory();
            DataTable dataTable = EmployeeDal.GetEmployee(employeeID);
            Employee employee = null;
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if (dataRow.Field<int>("EmployeeID") == employeeID)
                    {
                        if (dataRow.Field<bool>("IsHourlyPaid"))
                        {
                            employee = employeeFactory.CreateHourlyPaidEmployeeInstance
                                (dataRow.Field<string>("EmployeeType"), dataRow.Field<int>("EmployeeID"), dataRow.Field<int>("WorkHours"));
                        }
                        else
                        {
                            employee = employeeFactory.CreateConstantPaidEmployeeInstance
                               (dataRow.Field<string>("EmployeeType"), dataRow.Field<int>("EmployeeID"), dataRow.Field<double>("ConstantBasePayment"), dataRow.Field<int>("WorkHours"));
                        }
                    }
                }
                return employee;
            }
            return null;
        }

        public List<Employee> GetEmployeesByType(EmployeeTypeEnum employeeType)
        {
            CreateEmployeeFactory employeeFactoryre = new CreateEmployeeFactory();
            DataTable dataTable = EmployeeDal.GetEmployeesByType(employeeType.ToString());
            List<Employee> employees = new List<Employee>();
            Employee employee;
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if (dataRow.Field<bool>("IsHourlyPaid"))
                    {
                        employee = employeeFactoryre.CreateHourlyPaidEmployeeInstance
                            (employeeType.ToString(), dataRow.Field<int>("EmployeeID"), dataRow.Field<int>("WorkHours"));
                    }
                    else
                    {
                        employee = employeeFactoryre.CreateConstantPaidEmployeeInstance
                           (employeeType.ToString(), dataRow.Field<int>("EmployeeID"), dataRow.Field<double>("Payment"), dataRow.Field<int>("WorkHours"));
                    }

                    if (employee != null)
                    {
                        employees.Add(employee);
                    }

                }
                return employees;
            }
            return null;
        }

        public int GetEmployeesAmount()
        {
            DataTable dataTable = EmployeeDal.GetAllEmployees();
            if (dataTable != null)
            {
                return dataTable.Rows.Count;
            }
            return 0;
        }
    }
}
