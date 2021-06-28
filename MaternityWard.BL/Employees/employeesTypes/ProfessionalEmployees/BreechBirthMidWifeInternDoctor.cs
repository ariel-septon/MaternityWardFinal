using System.Collections.Generic;

namespace MaternityWard.BL
{
    public class BreechBirthMidWifeInternDoctor : InternDoctor
    {
        private HourlyPaidRank[] extraRanks;
        public BreechBirthMidWifeInternDoctor(int workHours, int id) : base(workHours, id)
        {
            this.EmployeeType = EmployeeTypeEnum.BreechBirthMidWifeInternDoctor;
        }
        public override void InitRanks()
        {
            base.InitRanks();
            this.extraRanks = new HourlyPaidRank[] { new Expert() };
            this.AddRanks(this.extraRanks);
        }
    }
}