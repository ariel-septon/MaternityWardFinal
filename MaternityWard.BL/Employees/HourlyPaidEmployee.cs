using System.Collections.Generic;

namespace MaternityWard.BL
{
    public abstract class HourlyPaidEmployee : Employee
    {
        public HourlyPaidEmployee(int workHours, int id): base(workHours, id)
        {
            this.IsHourlyPaid = true;
        }

        public abstract void InitRanks();

        public void SetWorkHours(int workHours)
        {
            this.WorkHours = workHours;
        }

        public int GetWorkHours()
        {
            return this.WorkHours;
        }
        private void SetWorkHoursForRanks(int workHours)
        {
            foreach (IRank rank in this.Ranks)
            {
                if (rank is HourlyPaidRank)
                {
                    HourlyPaidRank hourlyPaid = (HourlyPaidRank)rank;
                    hourlyPaid.WorkHours = workHours;
                }
            }
        }
        protected override double CalculateEarnings()
        {
            double maxSalary = 0;
            foreach (IRank rank in this.Ranks)
            {
                if (rank.SalaryCalculation() > maxSalary && !(rank is ExtraPaidRank))
                {
                    maxSalary = rank.SalaryCalculation();
                }
            }
            this.Payment = maxSalary;
            return maxSalary;
        }

        public override double GetPayment()
        {
            this.InitRanks();
            this.SetWorkHoursForRanks(this.WorkHours);
            this.CalculateEarnings();
            this.ExtraPaidCheck();
            return this.Payment;
        }
    }
}