using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Aspose.Cells;
using RADIndividualTask.Models1;

namespace RADIndividualTask.Frames
{
    public partial class OutputReportsFrame : Form
    {
        private int _selectedRowId;

        public OutputReportsFrame()
        {
            InitializeComponent();

            UpdateView();
            invoiceView.SelectionChanged += ChangeSelected;
            invoiceView.CellMouseDown += ChangeSelected;
        }

        private void UpdateView()
        {
            invoiceView.Refresh();
            invoiceView.DataSource = CRUD.Context.OutputReports.ToList();
        }

        private void ChangeSelected(object sender, EventArgs e)
        {
            for (int i = 0; i < invoiceView.Rows.Count; i++)
            {
                for (int j = 0; j < invoiceView.Rows[i].Cells.Count; j++)
                {
                    if (invoiceView.Rows[i].Cells[j].Selected)
                    {
                        _selectedRowId = int.Parse(invoiceView.Rows[i].Cells[6].Value.ToString());
                        break;
                    }
                }
            }
        }

        private void AddReport(object sender, EventArgs e)
        {
            var productOutputFrame = new OutputReportForm(addButton.Text);
            productOutputFrame.OnFrameClosedEvent += UpdateView;
            productOutputFrame.Show();
        }

        private void UpdateReport(object sender, EventArgs e)
        {
            var reportToUpdate = CRUD.Context.OutputReports.First(product => product.Id == _selectedRowId);
            var reportOutputFrame = new OutputReportForm(editButton.Text, reportToUpdate);
            reportOutputFrame.OnFrameClosedEvent += UpdateView;
            reportOutputFrame.Show();
        }

        private void CloseFrame(object sender, EventArgs e)
        {
            Close();
        }

        private void RemoveReport(object sender, EventArgs e)
        {
            var reportToRemove = CRUD.Context.OutputReports.First(report => report.Id == _selectedRowId);
            if (reportToRemove != null)
            {
                CRUD.Context.OutputReports.Remove<OutputReport>(reportToRemove);
            }
            UpdateView();
        }

        private void ExportInvoices(object sender, EventArgs e)
        {
            var workbook = new Workbook();
            var worksheet = workbook.Worksheets[0];
            
            var dataTable = new DataTable("InputInvoices");
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Наименование товара", typeof(string));
            dataTable.Columns.Add("Кол-во", typeof(int));
            dataTable.Columns.Add("Цена за штуку", typeof(double));
            dataTable.Columns.Add("Прибыль", typeof(double));
            dataTable.Columns.Add("Дата", typeof(string));

            foreach (var report in CRUD.Context.OutputReports.ToList())
            {
                var row = dataTable.NewRow();
                row[0] = report.Id;
                row[1] = report.Product.Name;
                row[2] = report.Count;
                row[3] = report.PricePerUnit;
                row[4] = report.TotalProfit;
                row[5] = report.Date.ToString();
                dataTable.Rows.Add(row);
            }

            worksheet.Cells.ImportData(dataTable, 0, 0, null);
            workbook.Save( "C:/Users/user/RiderProjects/RADIndividualTask/RADIndividualTask/OutputReports.xlsx");
        }
    }
}