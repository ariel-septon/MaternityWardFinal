using System;
using System.Collections.Generic;
using System.Text;
using MaternityWard.BL;

namespace MaternityWard.UI
{
    class EmployeeFactory
    {
        public EmployeeFactory()
        {
        }

        private double InsertPayment(string employeeType)
        {
            Console.WriteLine("please insert " + employeeType + " payment.");
            return double.Parse(Console.ReadLine());
        }

        private int InsertWorkHours(string employeeType)
        {
            Console.WriteLine("please insert " + employeeType + " work hours.");
            return int.Parse(Console.ReadLine());
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
