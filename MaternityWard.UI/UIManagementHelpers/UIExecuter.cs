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
        private readonly ManageEmployees manageEmployees = new ManageEmployees();
        private readonly ManageShifts manageShifts = new ManageShifts();
        private readonly UIPrinters uiPrinters = new UIPrinters();
        private readonly UIReaders uiReaders = new UIReaders();
        private readonly InputValidations inputValidations = new InputValidations();
        public UIExecuter()
        {
            this.employeeID = manageEmployees.GetEmployeesAmount() + 1;
            this.shiftID = manageShifts.GetShiftsAmount() + 1;
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
            int choice;
            do
            {
                choice = uiPrinters.PrintMenuOptions<MainMenuOptions>(uiReaders);
                ExecuteAction(choice);
                if (choice != 0)
                {
                    choice = uiPrinters.PrintMenuOptions<ReRunMenuOptions>(uiReaders);
                }
            } while (choice != 0);
        }
        private void AddEmployee()
        {
            int choice = uiPrinters.PrintMenuOptions<EmployeeTypeEnum>(uiReaders);
            if (Enum.IsDefined(typeof(EmployeeTypeEnum), choice))
            {
                InputEmployeeFactory factory = new InputEmployeeFactory();
                Employee emp = factory.CreateEmployeeInstance(Enum.GetName(typeof(EmployeeTypeEnum), choice), employeeID);
                employeeID += 1;
                inputValidations.DataValidCheck(uiPrinters, manageEmployees.AddEmployee(emp));
            }
        }
        private void InsertShiftHoursForEmployee()
        {
            int employeeID;
            uiPrinters.PrintWithConsole<string>("Please Enter EmployeeID: ");
            employeeID = uiReaders.GetUserInput<int>();
            Employee employee = manageEmployees.GetEmployeeByID(employeeID);

            if (inputValidations.IsEmployeeIDValid(uiPrinters, employee))
            {
                uiPrinters.PrintWithConsole<string>("insert hour in and hour out in the format-> hour:minutes (12:30)");
                DateTime hourIn = uiReaders.GetUserDateTime(DateTime.Now.Day, new DateTime());
                DateTime hourOut = uiReaders.GetUserDateTime(DateTime.Now.Day, hourIn);
                Shift shift = new Shift(shiftID, employeeID, hourIn, hourOut);
                shiftID += 1;
                inputValidations.DataValidCheck(uiPrinters, manageShifts.AddShift(shift));
            } 
        }
        private void ViewEmployeeSalary()
        {
            int employeeID;
            uiPrinters.PrintWithConsole<string>("Please Enter EmployeeID:");
            employeeID = uiReaders.GetUserInput<int>();

            Employee employee = manageEmployees.GetEmployeeByID(employeeID);
            if (inputValidations.IsEmployeeIDValid(uiPrinters, employee))
            {
                uiPrinters.PrintWithConsole<string>("The employee salary is " + employee.GetPayment());
            } 
        }
    }
}
