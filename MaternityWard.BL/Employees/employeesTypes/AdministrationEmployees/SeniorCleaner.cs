using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class SeniorCleaner : HourlyPaidEmployee
    {
        public SeniorCleaner(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Administration;
            this.EmployeeType = EmployeeTypeEnum.SeniorCleaner;
        }
        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Senior() };
            this.ranks = ranks;
        }
    }
}