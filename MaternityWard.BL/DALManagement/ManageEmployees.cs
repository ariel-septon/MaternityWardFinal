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
                Console.WriteLine("success!");
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
                               (dataRow.Field<string>("EmployeeType"), dataRow.Field<int>("EmployeeID"), dataRow.Field<double>("ConstantPayment"), dataRow.Field<int>("WorkHours"));
                        }
                    }
                }
            }
            ManageShifts manageShifts = new ManageShifts();
            List<Shift> shifts = manageShifts.GetShiftsByEmployeeID((employeeID));

            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            foreach (EmployeeTypeEnum employeeType in Enum.GetValues(typeof(EmployeeTypeEnum)))
            {
                employees.AddRange(GetEmployeesByType(employeeType));
            }
            return employees;
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
            }
            return employees;
        }
    }
}
