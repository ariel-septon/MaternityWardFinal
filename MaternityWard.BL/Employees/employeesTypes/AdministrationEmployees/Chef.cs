namespace MaternityWard.BL
{
    public class Chef : SousChef
    {
        private HourlyPaidRank[] extraRanks;
        public Chef(int workHours, int id) : base(workHours, id)
        {
            this.EmployeeType = EmployeeTypeEnum.Chef;
        }
        public override void InitRanks()
        {
            base.InitRanks();
            this.extraRanks = new HourlyPaidRank[] { new DecisionsMaker() };
            this.AddRanks(this.extraRanks);
        }
    }
}