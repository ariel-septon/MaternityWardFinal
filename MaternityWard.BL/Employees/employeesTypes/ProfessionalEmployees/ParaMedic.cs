using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class ParaMedic : HourlyPaidEmployee
    {
        public ParaMedic(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Professional;
            this.EmployeeType = EmployeeTypeEnum.Paramedic;
        }

        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Junior() };
            this.ranks = ranks;
        }
    }
}
