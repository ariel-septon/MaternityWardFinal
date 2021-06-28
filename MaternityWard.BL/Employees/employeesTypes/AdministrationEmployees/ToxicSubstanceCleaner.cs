namespace MaternityWard.BL
{
    public class ToxicSubstanceCleaner : Cleaner
    {
        private double extraPayment = 1.2;
        private IRank[] extraRanks;
        public ToxicSubstanceCleaner(int workHours, int id) : base(workHours, id)
        {
            this.EmployeeType = EmployeeTypeEnum.ToxicSubstanceCleaner;
        }
        public override void InitRanks()
        {
            // TODO change what atRisk recieves, and calculation;
            base.InitRanks();
            this.extraRanks = new IRank[] { new DecisionsMaker(), new Expert(), new AtRisk(this.extraPayment)};
            this.AddRanks(this.extraRanks);
        }
    }
}