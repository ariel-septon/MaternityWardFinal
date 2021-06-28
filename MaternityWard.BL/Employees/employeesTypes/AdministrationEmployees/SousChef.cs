namespace MaternityWard.BL
{
    public class SousChef : Cook
    {
        private HourlyPaidRank[] extraRanks;

        public SousChef(int workHours, int id) : base(workHours, id)
        {
            this.EmployeeType = EmployeeTypeEnum.SousChef;
        }
        public override void InitRanks()
        {
            base.InitRanks();
            this.extraRanks = new HourlyPaidRank[] { new Expert() };
            this.AddRanks(this.extraRanks);
        }
    }
}