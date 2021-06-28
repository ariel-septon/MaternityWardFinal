namespace MaternityWard.BL
{
    public abstract class ConstantPaidEmployee : Employee
    {
        public ConstantPaidEmployee(double payment, int workHours, int id): base(workHours, id)
        {
            this.Payment = payment;
            this.IsHourlyPaid = false;
        }

        public abstract void InitRanks();

        protected override double CalculateEarnings()
        {
            this.InitRanks();
            this.ExtraPaidCheck();
            return this.Payment;
        }

        public override double GetPayment()
        {
            return CalculateEarnings();
        }

    }
}