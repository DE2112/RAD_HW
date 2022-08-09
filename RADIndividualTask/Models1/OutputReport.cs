using System;
using System.Collections.Generic;

namespace RADIndividualTask.Models1
{
    public partial class OutputReport : BaseModel
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double PricePerUnit { get; set; }
        public double TotalProfit { get; set; }
        public DateTime Date { get; set; }

        public virtual Product Product { get; set; } = null!;

        public void UpdateReport(OutputReport newOutputReport)
        {
            ProductId = newOutputReport.ProductId;
            Count = newOutputReport.Count;
            PricePerUnit = newOutputReport.PricePerUnit;
            Date = newOutputReport.Date;
            TotalProfit = newOutputReport.TotalProfit;
            Product = CRUD.Context.Products.Find(ProductId);
        }
        
        public OutputReport(int productId, int count, double pricePerUnit, DateTime date)
        {
            ProductId = productId;
            Count = count;
            PricePerUnit = pricePerUnit;
            TotalProfit = count * PricePerUnit;
            Date = date;
            Product = CRUD.Context.Products.Find(ProductId);
            Product.OutputReports.Add(this);
        }
    }
}
