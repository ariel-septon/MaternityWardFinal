using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class AdministrationManager : ConstantPaidEmployee
    {
        public AdministrationManager(double payment, int workHours, int id) : base(payment, workHours, id)
        {
            this.Category = Category.Administration;
            this.EmployeeType = EmployeeTypeEnum.AdministrationManager;
        }

        public override void InitRanks()
        {
            List<IRank> ranks = new List<IRank> { new Manager(this.GetPayment()) };
            this.Ranks = ranks;
        }
    }
}