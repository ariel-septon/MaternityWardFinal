using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.BL
{
    public class EmployeeFactoryre
    {
        public EmployeeFactoryre()
        {
        }
        public Employee CreateConstantPaidEmployeeInstance(string employeeType, int id, double payment, int workHours)
        {
            employeeType = employeeType.ToString();

            if (employeeType == EmployeeTypeEnum.AdministrationManager.ToString())
            {
                return new AdministrationManager(payment, workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.DepartmentManager.ToString())
            {
                return new DepartmentManager(payment, workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.DeputyDepartmentManager.ToString())
            {
                return new DeputyDepartmentManager(payment, workHours, id);
            }

            return null;
        }

        public Employee CreateHourlyPaidEmployeeInstance(string employeeType, int id, int workHours)
        {
            employeeType = employeeType.ToString();

            if (employeeType == EmployeeTypeEnum.BreechBirthMidWifeInternDoctor.ToString())
            {
                return new BreechBirthMidWifeInternDoctor(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.BreechBirthMidWife.ToString())
            {
                return new BreechBirthMidWife(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.BreechBirthMidWifeTraineeDoctor.ToString())
            {
                return new BreechBirthMidWifeTraineeDoctor(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.Chef.ToString())
            {
                return new Chef(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.Cleaner.ToString())
            {
                return new Cleaner(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.CleanersSupervisor.ToString())
            {
                return new CleanersSupervisor(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.Cook.ToString())
            {
                return new Cook(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.Doctor.ToString())
            {
                return new Doctor(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.ExpertDoctor.ToString())
            {
                return new ExpertDoctor(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.FoodGiver.ToString())
            {
                return new FoodGiver(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.HeadNurse.ToString())
            {
                return new HeadNurse(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.InternDoctor.ToString())
            {
                return new InternDoctor(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.Medic.ToString())
            {
                return new Medic(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.MidWife.ToString())
            {
                return new MidWife(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.Nurse.ToString())
            {
                return new Nurse(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.Paramedic.ToString())
            {
                return new ParaMedic(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.SeniorCleaner.ToString())
            {
                return new SeniorCleaner(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.SeniorDoctor.ToString())
            {
                return new SeniorDoctor(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.SousChef.ToString())
            {
                return new SousChef(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.ToxicSubstanceCleaner.ToString())
            {
                return new ToxicSubstanceCleaner(workHours, id);
            }
            if (employeeType == EmployeeTypeEnum.TraineeDoctor.ToString())
            {
                return new TraineeDoctor(workHours, id);
            }
            return null;
        }
    }
}
