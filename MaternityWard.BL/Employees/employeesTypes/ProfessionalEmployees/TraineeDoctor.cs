using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class TraineeDoctor : HourlyPaidEmployee
    {
        public TraineeDoctor(int workHours, int id) : base(workHours, id)
        {
            this.Category = Category.Professional;
            this.EmployeeType = EmployeeTypeEnum.TraineeDoctor;
        }

        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Junior() };
            this.ranks = ranks;
        }
    }
}