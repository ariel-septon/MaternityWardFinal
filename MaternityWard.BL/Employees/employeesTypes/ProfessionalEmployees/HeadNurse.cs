using System.Collections.Generic;

namespace MaternityWard.BL
{
    public class HeadNurse : HourlyPaidEmployee
    {
        public HeadNurse(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Professional;
            this.EmployeeType = EmployeeTypeEnum.HeadNurse;
        }

        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Senior(), new DecisionsMaker() };
            this.ranks = ranks;
        }
    }
}