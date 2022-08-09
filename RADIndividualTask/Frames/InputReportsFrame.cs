using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RADIndividualTask.Models1;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Aspose.Cells;

namespace RADIndividualTask.Frames
{
    public partial class InputReportsFrame : Form
    {
        private Application _app;
        private Workbook _wb;
        private Worksheet _ws;
        private int _selectedRowId;

        public InputReportsFrame()
        {
            InitializeComponent();

            UpdateView();
            invoiceView.SelectionChanged += ChangeSelected;
            invoiceView.CellMouseDown += ChangeSelected;
        }

        private void UpdateView()
        {
            invoiceView.Refresh();
            invoiceView.DataSource = CRUD.Context.InputReports.ToList();
        }

        private void ChangeSelected(object sender, EventArgs e)
        {
            for (int i = 0; i < invoiceView.Rows.Count; i++)
            {
                for (int j = 0; j < invoiceView.Rows[i].Cells.Count; j++)
                {
                    if (invoiceView.Rows[i].Cells[j].Selected)
                    {
                        _selectedRowId = int.Parse(invoiceView.Rows[i].Cells[7].Value.ToString());
                        break;
                    }
                }
            }
            
            
        }

        private void AddReport(object sender, EventArgs e)
        {
            var productInputFrame = new InputReportForm(buttonAdd.Text);
            productInputFrame.OnFrameClosedEvent += UpdateView;
            productInputFrame.Show();
        }

        private void UpdateReport(object sender, EventArgs e)
        {
            var reportToUpdate = CRUD.Context.InputReports.First(product => product.Id == _selectedRowId);
            var reportInputFrame = new InputReportForm(buttonEdit.Text, reportToUpdate);
            reportInputFrame.OnFrameClosedEvent += UpdateView;
            reportInputFrame.Show();
        }

        private void DeleteReport(object sender, EventArgs e)
        {
            var reportToRemove = CRUD.Context.InputReports.First(report => report.Id == _selectedRowId);
            if (reportToRemove != null)
            {
                CRUD.Context.InputReports.Remove<InputReport>(reportToRemove);
            }
            UpdateView();
        }

        private void CloseFrame(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportInvoices(object sender, EventArgs e)
        {
            var workbook = new Workbook();
            var worksheet = workbook.Worksheets[0];
            
            var dataTable = new DataTable("InputInvoices");
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Наименование материала", typeof(string));
            dataTable.Columns.Add("Кол-во", typeof(double));
            dataTable.Columns.Add("Цена за штуку", typeof(double));
            dataTable.Columns.Add("Итого", typeof(double));
            dataTable.Columns.Add("Уплачено", typeof(double));
            dataTable.Columns.Add("Дата", typeof(string));

            foreach (var report in CRUD.Context.InputReports.ToList())
            {
                var row = dataTable.NewRow();
                row[0] = report.Id;
                row[1] = report.Material.Name;
                row[2] = report.Units;
                row[3] = report.CostPerUnit;
                row[4] = report.TotalCost;
                row[5] = report.Paid;
                row[6] = report.Date.ToString();
                dataTable.Rows.Add(row);
            }

            worksheet.Cells.ImportData(dataTable, 0, 0, null);
            workbook.Save( "C:/Users/user/RiderProjects/RADIndividualTask/RADIndividualTask/InputReports.xlsx");
        }
    }
}
