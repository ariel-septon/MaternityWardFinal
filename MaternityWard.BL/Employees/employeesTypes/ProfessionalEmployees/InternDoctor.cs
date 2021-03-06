using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class InternDoctor : HourlyPaidEmployee
    {
        public InternDoctor(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Professional;
            this.EmployeeType = EmployeeTypeEnum.InternDoctor;
        }

        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Junior() };
            this.ranks = ranks;
        }
    }
}