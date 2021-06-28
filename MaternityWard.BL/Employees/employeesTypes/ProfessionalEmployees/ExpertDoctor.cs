namespace MaternityWard.BL
{
    public class ExpertDoctor : SeniorDoctor
    {
        private HourlyPaidRank[] extraRanks;
        public ExpertDoctor(int workHours, int id) : base(workHours, id)
        {
            this.EmployeeType = EmployeeTypeEnum.SeniorDoctor;
        }
        public override void InitRanks()
        {
            base.InitRanks();
            this.extraRanks = new HourlyPaidRank[] { new Expert() };
            this.AddRanks(this.extraRanks);
        }
    }
}