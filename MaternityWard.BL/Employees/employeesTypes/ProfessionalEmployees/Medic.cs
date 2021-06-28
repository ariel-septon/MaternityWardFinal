using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class Medic : HourlyPaidEmployee
    {
        public Medic(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Professional;
            this.EmployeeType = EmployeeTypeEnum.Medic;
        }
        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Junior() };
            this.ranks = ranks;
        }
    }
}