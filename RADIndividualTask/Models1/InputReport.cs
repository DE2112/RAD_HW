using System;

namespace RADIndividualTask.Models1
{
    public partial class InputReport : BaseModel
    {
        public int MaterialId { get; set; }
        public double Units { get; set; }
        public double CostPerUnit { get; set; }
        public double TotalCost { get; set; }
        public double Paid { get; set; }
        public DateTime Date { get; set; }

        public virtual Material Material { get; set; } = null!;
        
        public void UpdateReport(InputReport newInputReport)
        {
            ResetLoan();
            MaterialId = newInputReport.MaterialId;
            Units = newInputReport.Units;
            CostPerUnit = newInputReport.CostPerUnit;
            Paid = newInputReport.Paid;
            Date = newInputReport.Date;
            Material = CRUD.Context.Materials.Find(MaterialId);
            TotalCost = Units * CostPerUnit;
        }
        
        public InputReport(int materialId, double units, double costPerUnit, double paid, DateTime date)
        {
            MaterialId = materialId;
            Units = units;
            CostPerUnit = costPerUnit;
            Paid = paid;
            Date = date;
            Material = CRUD.Context.Materials.Find(MaterialId);
            Material.InputReports.Add(this);
            TotalCost = Units * CostPerUnit;
            SetLoan();
        }

        private void ResetLoan()
        {
            var loan = TotalCost - Paid;
            CRUD.Context.Materials.Find(MaterialId).Provider.Loan -= loan;
        }
        
        private void SetLoan()
        {
            var loan = TotalCost - Paid;
            CRUD.Context.Materials.Find(MaterialId).Provider.Loan += loan;
        }
    }
}
