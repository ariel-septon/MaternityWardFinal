namespace MaternityWard.BL
{
    public abstract class ConstantPaidRank : IRank
    {
        private double payment;

        protected double Payment { get => payment; set => payment = value; }

        public virtual double SalaryCalculation()
        {
            return Payment;
        }
    }
}