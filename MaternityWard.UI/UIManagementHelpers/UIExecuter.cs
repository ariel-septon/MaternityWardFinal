using MaternityWard.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.UI
{
    public class UIExecuter
    {
        private int employeeID;
        private int shiftID;
        private readonly UIPrinters uiPrinters = new UIPrinters();
        private readonly UIReaders uiReaders = new UIReaders();
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public  int ShiftID { get => shiftID; set => shiftID = value; }

        public UIExecuter(int employeeID, int shiftID)
        {
            this.EmployeeID = employeeID;
            this.ShiftID = shiftID;
        }

        private void ExecuteAction(int choice)
        {
            switch (choice)
            {
                case 0:
                    uiPrinters.PrintWithConsole<string>("Exit :)");
                    break;
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    InsertShiftHoursForEmployee();
                    break;
                case 3:
                    ViewEmployeeSalary();
                    break;
                default:
                    uiPrinters.PrintWithConsole<string>("please enter a valid option.");
                    break;
            }
        }
        public void MainMenu()
        {
            int choice = uiPrinters.PrintMenuOptions<MainMenuOptions>();
            ExecuteAction(choice);
        }
        private void AddEmployee()
        {
            int choice = uiPrinters.PrintMenuOptions<EmployeeTypeEnum>();
            if (Enum.IsDefined(typeof(EmployeeTypeEnum), choice))
            {
                EmployeeFactory factory = new EmployeeFactory();
                Employee emp = factory.CreateEmployeeInstance(Enum.GetName(typeof(EmployeeTypeEnum), choice), employeeID);
                employeeID += 1;
                ManageEmployees manage = new ManageEmployees();
                manage.AddEmployee(emp);
            }
        }
        private  void InsertShiftHoursForEmployee()
        {
            int employeeID;
            uiPrinters.PrintWithConsole<string>("Please Enter EmployeeID: ");
            employeeID = uiReaders.GetUserChoice();

            ManageEmployees manageEmployees = new ManageEmployees();
            ManageShifts manageShifts = new ManageShifts();

            manageEmployees.GetEmployeeByID(employeeID);
            uiPrinters.PrintWithConsole<string>("insert hour in and hour out in the format: 0100 <-> 2400");
            int hourIn = uiReaders.GetUserChoice();
            int hourOut = uiReaders.GetUserChoice();
            Shift shift = new Shift(ShiftID, employeeID, hourIn, hourOut);
            ShiftID += 1;
            manageShifts.AddShift(shift);
        }
        private  void ViewEmployeeSalary()
        {
            int employeeID;
            uiPrinters.PrintWithConsole<string>("Please Enter EmployeeID:");
            employeeID = uiReaders.GetUserChoice();

            ManageEmployees manageEmployees = new ManageEmployees();

            Employee employee = manageEmployees.GetEmployeeByID(employeeID);
            uiPrinters.PrintWithConsole<double>(employee.CalculateEarnings());
        }
    }
}
