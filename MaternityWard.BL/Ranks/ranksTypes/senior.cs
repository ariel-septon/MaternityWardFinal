namespace MaternityWard.BL
{
    public class Senior : HourlyPaidRank
    {

        private const double EXTRA_PAY_PRECENTAGE = 1.05;
        public Senior()
        {
            this.IncreaseHourlyPayRate(EXTRA_PAY_PRECENTAGE);
        }
    }
}