using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityWard.BL
{
    public abstract class ExtraPaidRank: IRank
    {
        private double baseSalary;
        private double extraPayment;

        protected ExtraPaidRank(double extraPayment)
        {
            this.extraPayment = extraPayment;
        }

        public double BaseSalary { get => baseSalary; set => baseSalary = value; }
        protected double ExtraPayment { get => extraPayment; set => extraPayment = value; }

        public double SalaryCalculation()
        {
            return this.BaseSalary * this.ExtraPayment;
        }
    }

}
