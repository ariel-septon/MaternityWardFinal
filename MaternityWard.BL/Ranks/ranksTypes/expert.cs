namespace MaternityWard.BL
{
    public class Expert : HourlyPaidRank
    {
        private const double EXTRA_PAY_PRECENTAGE = 1.3;

        public Expert()
        {
            this.IncreaseHourlyPayRate(EXTRA_PAY_PRECENTAGE);
        }
    }
}