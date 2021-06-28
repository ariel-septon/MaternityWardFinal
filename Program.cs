using MaternityWard.BL;
using System;

namespace MaternityWard.UI
{

    class Program
    {
        public static int employeeID = 25;
        public static int shiftID = 1;
        static void Main(string[] args)
        {


            //PrintMenuOptions();
            // AddEmployeeInterface(id);
            // InsertShiftHoursForEmployee();
            ViewEmployeeSalary();
            Console.ReadKey();
        }

        public static void PrintMenuOptions()
        {
            int choice;
            do
            {
                Console.WriteLine("Please Choose option from the menu:");
                foreach (MenuOptions menuOption in Enum.GetValues(typeof(MenuOptions)))
                {
                    Console.WriteLine((int)menuOption + ") " + menuOption.ToString());
                }
                choice = int.Parse(Console.ReadLine());
                ExecuteAction(choice);

            } while (choice > 0);

        }

        public static void AddEmployeeInterface(int id)
        {
            int choice;
            do
            {
                Console.WriteLine("Please Choose Employee:");
                foreach (EmployeeTypeEnum employeeType in Enum.GetValues(typeof(EmployeeTypeEnum)))
                {
                    Console.WriteLine((int)employeeType + ") " + employeeType.ToString());
                }
                choice = int.Parse(Console.ReadLine());
                if (Enum.IsDefined(typeof(EmployeeTypeEnum), choice))
                {
                    EmployeeFactory factory = new EmployeeFactory();
                    Employee emp = factory.CreateEmployeeInstance(Enum.GetName(typeof(EmployeeTypeEnum), choice), id);
                    id += 1;
                    ManageEmployees manage = new ManageEmployees();
                    manage.AddEmployee(emp);
                }
            } while (!Enum.IsDefined(typeof(EmployeeTypeEnum), choice));

        }

        public static void InsertShiftHoursForEmployee()
        {
            int employeeID;
            Console.WriteLine("Please Enter EmployeeID:");
            employeeID = int.Parse(Console.ReadLine());

            ManageEmployees manageEmployees = new ManageEmployees();
            ManageShifts manageShifts = new ManageShifts();

            manageEmployees.GetEmployeeByID(employeeID);
            Console.WriteLine("insert hour in and hour out in the format: 0100 <-> 2400");
            int hourIn = int.Parse(Console.ReadLine());
            int hourOut = int.Parse(Console.ReadLine());
            Shift shift = new Shift(shiftID, employeeID, hourIn, hourOut);
            manageShifts.AddShift(shift);
        }

        public static void ViewEmployeeSalary()
        {
            int employeeID;
            Console.WriteLine("Please Enter EmployeeID:");
            employeeID = int.Parse(Console.ReadLine());

            ManageEmployees manageEmployees = new ManageEmployees();
            ManageShifts manageShifts = new ManageShifts();

            Employee employee = manageEmployees.GetEmployeeByID(employeeID);

            Console.WriteLine(employee.CalculateEarnings());
        }

        public static void EmployeesCount()
        {
            int employeeID;
            Console.WriteLine("Please Enter EmployeeID:");
            employeeID = int.Parse(Console.ReadLine());

            ManageEmployees manage = new ManageEmployees();
            Console.WriteLine(manage.GetAllEmployees().Count);
        }


        public static void ExecuteAction(int choice)
        {
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Exit :)");
                    break;
                case 1:
                    AddEmployeeInterface(employeeID);
                    break;
                case 2:
                    InsertShiftHoursForEmployee();
                    break;
                case 3:
                    ViewEmployeeSalary();
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
