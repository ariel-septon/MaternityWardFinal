using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class Nurse : HourlyPaidEmployee
    {
        public Nurse(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Professional;
            this.EmployeeType = EmployeeTypeEnum.Nurse;
        }

        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Junior() };
            this.ranks = ranks;
        }
    }
}