using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class MidWife : HourlyPaidEmployee
    {
        public MidWife(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Professional;
            this.EmployeeType = EmployeeTypeEnum.MidWife;
        }

        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Senior() };
            this.ranks = ranks;
        }
    }
}