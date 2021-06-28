namespace MaternityWard.BL
{
    public abstract class ConstantPaidEmployee : Employee
    {
        private readonly double baseSalary;
        public ConstantPaidEmployee(double baseSalary, int workHours, int id): base(workHours, id)
        {
            this.baseSalary = baseSalary;
            this.Payment = baseSalary;
            this.IsHourlyPaid = false;
        }

        public abstract void InitRanks();

        protected override double CalculateEarnings()
        {
            this.InitRanks();
            return this.baseSalary;
        }

        public override double GetPayment()
        {
            this.CalculateEarnings();
            this.ExtraPaidCheck();
            return this.Payment;
        }

    }
}