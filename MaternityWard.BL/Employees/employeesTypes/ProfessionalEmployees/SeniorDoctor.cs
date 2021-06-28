namespace MaternityWard.BL
{
    public class SeniorDoctor : Doctor
    {
        private HourlyPaidRank[] extraRanks;
        public SeniorDoctor(int workHours, int id) : base(workHours, id)
        {
            this.EmployeeType = EmployeeTypeEnum.SeniorDoctor;
        }
        public override void InitRanks()
        {
            base.InitRanks();
            this.extraRanks = new HourlyPaidRank[] { new DecisionsMaker() };
            this.AddRanks(this.extraRanks);
        }
    }
}