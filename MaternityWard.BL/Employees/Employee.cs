using System;
using System.Collections.Generic;
using System.Data;
using MaternityWard.DAL;

namespace MaternityWard.BL
{
    public abstract class Employee
    {
        private int id;
        private EmployeeTypeEnum employeeType;
        private int workHours;
        private Category category;
        private double payment;
        private bool isHourlyPaid;

        protected List<IRank> ranks = new List<IRank>();
        public int WorkHours { get => workHours; set => workHours = value; }
        public Category Category { get => category; set => category = value; }
        public EmployeeTypeEnum EmployeeType { get => employeeType; set => employeeType = value; }
        public List<IRank> Ranks { get => ranks; set => ranks = value; }
        public bool IsHourlyPaid { get => isHourlyPaid; set => isHourlyPaid = value; }
        public int Id { get => id; set => id = value; }
        public double Payment { get => payment; set => payment = value; }

        public Employee(int workHours, int id)
        {
            this.workHours = workHours;
            this.id = id;
        }
        public abstract double CalculateEarnings();

        public void AddRanks(IRank[] ranks)
        {
            foreach (IRank rank in ranks)
            {
                this.Ranks.Add(rank);
            }
        }
        protected virtual double GetPayment()
        {
            return this.Payment;
        }

        protected bool ExtraPaidCheck()
        {
            foreach (IRank rank in this.Ranks)
            {
                if (rank is ExtraPaidRank)
                {
                    ExtraPaidRank extraPaid = (ExtraPaidRank)rank;
                    extraPaid.BaseSalary = this.CalculateEarnings();
                    this.Payment = extraPaid.SalaryCalculation();
                    return true;
                }
            }
            return false;
        }
    }
}
