using System.Data.SqlClient;
namespace MaternityWard.BL
{
    public abstract class HourlyPaidRank : IRank
    {
        private int workHours;
        private double hourlyPayRate;
        private double payment;

        protected double HourlyPayRate { get => hourlyPayRate; set => hourlyPayRate = value; }
        public int WorkHours { get => workHours; set => workHours = value; }
        protected double Payment { get => payment; set => payment = this.SalaryCalculation(); }

        protected HourlyPaidRank()
        {
            this.HourlyPayRate = Consts.basicHourlyPayRate;
        }
        public void IncreaseHourlyPayRate(double extraPayment)
        {
            this.HourlyPayRate *= extraPayment;
        }

        public virtual double SalaryCalculation()
        {
            return this.workHours * this.hourlyPayRate;
        }
    }
}