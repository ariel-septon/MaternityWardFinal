using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class BreechBirthMidWifeTraineeDoctor : InternDoctor
    {
        private HourlyPaidRank[] extraRanks;
        public BreechBirthMidWifeTraineeDoctor(int workHours, int id) : base(workHours, id)
        {
            this.EmployeeType = EmployeeTypeEnum.BreechBirthMidWifeTraineeDoctor;
        }

        public override void InitRanks()
        {
            base.InitRanks();
            this.extraRanks = new HourlyPaidRank[] { new Expert() };
            this.AddRanks(this.extraRanks);
        }
    }
}