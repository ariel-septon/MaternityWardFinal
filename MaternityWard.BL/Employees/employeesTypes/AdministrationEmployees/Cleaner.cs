using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class Cleaner : HourlyPaidEmployee
    {
        public Cleaner(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Administration;
            this.EmployeeType = EmployeeTypeEnum.Cleaner;
        }
        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Junior() };
            this.ranks = ranks ;
        }
    }
}