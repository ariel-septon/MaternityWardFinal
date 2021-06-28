using System;
using System.Collections.Generic;
using System.Text;
using MaternityWard.BL;

namespace MaternityWard.UI
{
    class InputEmployeeFactory
    {
        private readonly UIPrinters uiPrinters = new UIPrinters();
        private readonly UIReaders uiReaders = new UIReaders();
        public InputEmployeeFactory()
        {
        }

        private double InsertPayment(string employeeType)
        {
            uiPrinters.PrintWithConsole<string>("please insert " + employeeType + " base salary.");
            return uiReaders.GetUserInput<double>();
        }

        private int InsertWorkHours(string employeeType)
        {
            uiPrinters.PrintWithConsole<string>("please insert the " + employeeType + "'s monthly work hours by now. ");
            return uiReaders.GetUserInput<int>();
        }

        public Employee CreateEmployeeInstance(string employeeType, int id)
        {
            employeeType = employeeType.ToString();

            if (employeeType == EmployeeTypeEnum.AdministrationManager.ToString())
            {
                return new AdministrationManager(InsertPayment(employeeType), InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.BreechBirthMidWifeInternDoctor.ToString())
            {
                return new BreechBirthMidWifeInternDoctor(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.BreechBirthMidWife.ToString())
            {
                return new BreechBirthMidWife(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.BreechBirthMidWifeTraineeDoctor.ToString())
            {
                return new BreechBirthMidWifeTraineeDoctor(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.Chef.ToString())
            {
                return new Chef(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.Cleaner.ToString())
            {
                return new Cleaner(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.CleanersSupervisor.ToString())
            {
                return new CleanersSupervisor(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.Cook.ToString())
            {
                return new Cook(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.DepartmentManager.ToString())
            {
                return new DepartmentManager(InsertPayment(employeeType), InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.DeputyDepartmentManager.ToString())
            {
                return new DeputyDepartmentManager(InsertPayment(employeeType), InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.Doctor.ToString())
            {
                return new Doctor(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.ExpertDoctor.ToString())
            {
                return new ExpertDoctor(InsertWorkHours(employeeType), id);
            }       
            if (employeeType == EmployeeTypeEnum.FoodGiver.ToString())
            {
                return new FoodGiver(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.HeadNurse.ToString())
            {
                return new HeadNurse(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.InternDoctor.ToString())
            {
                return new InternDoctor(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.Medic.ToString())
            {
                return new Medic(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.MidWife.ToString())
            {
                return new MidWife(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.Nurse.ToString())
            {
                return new Nurse(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.Paramedic.ToString())
            {
                return new ParaMedic(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.SeniorCleaner.ToString())
            {
                return new SeniorCleaner(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.SeniorDoctor.ToString())
            {
                return new SeniorDoctor(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.SousChef.ToString())
            {
                return new SousChef(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.ToxicSubstanceCleaner.ToString())
            {
                return new ToxicSubstanceCleaner(InsertWorkHours(employeeType), id);
            }
            if (employeeType == EmployeeTypeEnum.TraineeDoctor.ToString())
            {
                return new TraineeDoctor(InsertWorkHours(employeeType), id);
            }
            throw new Exception("The type provided does not exist");
        }
    }
}
