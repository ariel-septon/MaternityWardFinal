using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class CleanersSupervisor : HourlyPaidEmployee
    {
        public CleanersSupervisor(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Administration;
            this.EmployeeType = EmployeeTypeEnum.CleanersSupervisor ;
        }

        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new DecisionsMaker() };
            this.ranks = ranks;
        }
    }
}