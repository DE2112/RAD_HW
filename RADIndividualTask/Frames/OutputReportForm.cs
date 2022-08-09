using System;
using System.Linq;
using System.Windows.Forms;
using RADIndividualTask.Models1;

namespace RADIndividualTask.Frames
{
    public partial class OutputReportForm : Form
    {
        private OutputReport _report;

        public event Action OnFrameClosedEvent;

        public OutputReportForm(string frameName)
        {
            InitializeComponent();
            Text = frameName;

            FillMaterialList();
        }

        public OutputReportForm(string frameName, OutputReport outputReport)
        {
            InitializeComponent();
            Text = frameName;
            _report = outputReport;

            FillMaterialList();
            FillFields(outputReport);
        }

        private void FillMaterialList()
        {
            productsListField.Text = "";
            foreach (var product in CRUD.Context.Products.ToList())
            {
                productsListField.Text += $"{product.Id} - {product.Name}\n";
            }
        }

        private void FillFields(OutputReport report)
        {
            productIdField.Value = report.Id;
            countField.Value = report.Count;
            pricePerUnitField.Text = report.PricePerUnit.ToString();
            dateField.Value = report.Date;
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            error.Text = "";

            var product = CRUD.Context.Products.Find((int)productIdField.Value);
            if (product != null && pricePerUnitField.Text != "")
            {
                var newReport = new OutputReport((int) productIdField.Value, (int) countField.Value,
                    double.Parse(pricePerUnitField.Text), dateField.Value);
                
                if (_report == null)
                {
                    _report = newReport;
                    CRUD.Context.OutputReports.Add<OutputReport>(_report);
                } 
                else
                {
                    CRUD.Context.OutputReports.ToList().First(report => report.Id == _report.Id).UpdateReport(newReport);
                }
            
                CloseFrame(sender, e);
            }
            else
            {
                error.Text = "Нет заданного товара!";
            }
        }

        private void CloseFrame(object sender, EventArgs e)
        {
            OnFrameClosedEvent?.Invoke();
            Close();
        }
    }
}