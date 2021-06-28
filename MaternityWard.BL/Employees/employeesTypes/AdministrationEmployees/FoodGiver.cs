using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class FoodGiver : HourlyPaidEmployee
    {
        public FoodGiver(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Administration;
            this.EmployeeType = EmployeeTypeEnum.FoodGiver;
        }
        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Junior() };
            this.ranks = ranks;
        }
    }
}