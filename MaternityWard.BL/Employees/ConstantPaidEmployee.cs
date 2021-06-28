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

        public override double CalculateEarnings()
        {
            this.InitRanks();
            this.ExtraPaidCheck();
            return this.Payment;
        }

        protected override double GetPayment()
        {
            return this.Payment;
        }

    }
}