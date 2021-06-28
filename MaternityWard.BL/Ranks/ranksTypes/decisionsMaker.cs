namespace MaternityWard.BL
{
    public class DecisionsMaker : HourlyPaidRank
    {
        private const double EXTRA_PAY_PRECENTAGE = 1.5;
        private int defaultWorkHours = 200;
        public DecisionsMaker()
        {
            this.IncreaseHourlyPayRate(EXTRA_PAY_PRECENTAGE);
        }
        public override double SalaryCalculation()
        {
            if (this.WorkHours > 50)
            {
                return this.HourlyPayRate * this.defaultWorkHours;
            }
            else
            {
                return base.SalaryCalculation();
            }
        }
    }
}