using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class BreechBirthMidWife : MidWife
    {
        private HourlyPaidRank[] extraRanks;
        public BreechBirthMidWife(int workHours, int id) : base(workHours, id)
        {
        }

        public override void InitRanks()
        {
            base.InitRanks();
            this.extraRanks = new HourlyPaidRank[] { new Expert() };
            this.AddRanks(this.extraRanks);
        }
    }
}