using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class DeputyDepartmentManager : ConstantPaidEmployee
    {
        public DeputyDepartmentManager(double payment, int workHours, int id) : base(payment, workHours, id)
        {
            this.Category = Category.Professional;
            this.EmployeeType = EmployeeTypeEnum.DeputyDepartmentManager;
        }

        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Manager(this.Payment) };
            this.Ranks = ranks;
        }
    }
}