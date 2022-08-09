using RADIndividualTask.Models1;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RADIndividualTask.Frames
{
    public partial class InputReportForm : Form
    {
        private InputReport _report;

        public event Action OnFrameClosedEvent;

        public InputReportForm(string frameName)
        {
            InitializeComponent();
            Text = frameName;

            FillMaterialList();
        }

        public InputReportForm(string frameName, InputReport inputReport)
        {
            InitializeComponent();
            Text = frameName;
            _report = inputReport;

            FillMaterialList();
            FillFields(inputReport);
        }

        private void FillMaterialList()
        {
            materialsListField.Text = "";
            foreach (var material in CRUD.Context.Materials.ToList())
            {
                materialsListField.Text += $"{material.Id} - {material.Name}\n";
            }
        }

        private void FillFields(InputReport report)
        {
            materialIdField.Value = report.Id;
            unitsField.Text = report.Units.ToString();
            costPerUnitField.Text = report.CostPerUnit.ToString();
            paidField.Text = report.Paid.ToString();
            dateField.Value = report.Date;
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            error.Text = "";

            var material = CRUD.Context.Materials.Find((int)materialIdField.Value);
            if (material != null && unitsField.Text != "" && costPerUnitField.Text != "" && paidField.Text != "")
            {
                var newReport = new InputReport((int) materialIdField.Value, double.Parse(unitsField.Text),
                    double.Parse(costPerUnitField.Text), double.Parse(paidField.Text), dateField.Value);
                
                if (_report == null)
                {
                    _report = newReport;
                    CRUD.Context.InputReports.Add<InputReport>(_report);
                } 
                else
                {
                    CRUD.Context.InputReports.ToList().First(report => report.Id == _report.Id).UpdateReport(newReport);
                }
            
                CloseFrame(sender, e);
            }
            else
            {
                error.Text = "Нет заданного материала!";
            }
            
        }

        private void CloseFrame(object sender, EventArgs e)
        {
            OnFrameClosedEvent?.Invoke();
            Close();
        }
    }
}
