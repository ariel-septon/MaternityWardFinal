using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class Cook : HourlyPaidEmployee
    {
        public Cook(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Administration;
            this.EmployeeType = EmployeeTypeEnum.Cook;
        }
        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Senior() };
            this.ranks = ranks;
        }
    }
}