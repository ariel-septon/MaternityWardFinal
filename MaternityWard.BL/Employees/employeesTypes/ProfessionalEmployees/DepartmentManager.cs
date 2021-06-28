using System.Collections.Generic;
namespace MaternityWard.BL
{
    public class DepartmentManager : DeputyDepartmentManager
    {
        private IRank[] extraRanks;
        private double extraPayment = 2;

        public DepartmentManager(double payment, int workHours, int id) : base(payment, workHours, id)
        {
            this.EmployeeType = EmployeeTypeEnum.DepartmentManager;
        }

        public override void InitRanks()
        {
            base.InitRanks();
            this.extraRanks = new IRank[] { new AtRisk(this.extraPayment) };
            this.AddRanks(this.extraRanks);
        }
    }
}