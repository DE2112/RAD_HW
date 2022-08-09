using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Aspose.Cells;
using RADIndividualTask.Models1;

namespace RADIndividualTask.Frames
{
    public partial class MaterialReportForm : Form
    {
        public MaterialReportForm()
        {
            InitializeComponent();
        }

        private void CloseFrame(object sender, EventArgs e)
        {
            Close();
        }

        private void MakeReport(object sender, EventArgs e)
        {
            error.Text = "";
            var fromDate = fromDateField.Value;
            var toDate = toDateField.Value;

            if (fromDate < toDate)
            {
                var inReportsInRange = CRUD.Context.InputReports.ToList()
                    .Where(report => report.Date.IsInRange(fromDate, toDate)).ToList();
                var outReportsInRange = CRUD.Context.OutputReports.ToList()
                    .Where(report => report.Date.IsInRange(fromDate, toDate)).ToList();

                var targetMaterials = new List<Material>();
                foreach (var material in CRUD.Context.Materials.ToList())
                {
                    var targetReports = inReportsInRange.Where(report => report.MaterialId == material.Id).ToList();
                    var sortedInReports = targetReports.OrderBy(report => report.Date).ToList();

                    var isTargetMaterial = sortedInReports.Count > 1;
                    for (int i = 1; i < sortedInReports.Count; i++)
                    {
                        if (sortedInReports[i].CostPerUnit < sortedInReports[i - 1].CostPerUnit)
                            isTargetMaterial = false;
                    }
                    
                    if (isTargetMaterial) targetMaterials.Add(material);
                }

                inReportsInRange = inReportsInRange.Where(report => targetMaterials.Contains(report.Material)).ToList();

                foreach (var report in outReportsInRange)
                {
                    var productMaterials = report.Product.GetMaterials();

                    foreach (var keyValuePair in productMaterials)
                    {
                        var material = CRUD.Context.Materials.Find(keyValuePair.Key);
                        if (targetMaterials.Contains(material))
                        {
                            inReportsInRange.Add(new InputReport(material.Id, -keyValuePair.Value, 
                                0f, 0f, report.Date));
                        }
                    }
                }
                
                var workbook = new Workbook();
                var worksheet = workbook.Worksheets[0];
            
                var dataTable = new DataTable("MaterialsReport");
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Наименование материала", typeof(string));
                dataTable.Columns.Add("Кол-во материалов (м)", typeof(double));
                dataTable.Columns.Add("Цена за единицу", typeof(double));
                dataTable.Columns.Add("Итого", typeof(double));
                dataTable.Columns.Add("Заплачено", typeof(double));
                dataTable.Columns.Add("Долг", typeof(double));
                dataTable.Columns.Add("Дата", typeof(string));



                foreach (var report in inReportsInRange)
                {
                    var row = dataTable.NewRow();
                    row[0] = report.Id;
                    row[1] = report.Material.Name;
                    row[2] = report.Units;
                    row[3] = report.CostPerUnit;
                    row[4] = report.TotalCost;
                    row[5] = report.Paid;
                    row[6] = report.TotalCost - report.Paid;
                    row[7] = report.Date.ToString();
                    dataTable.Rows.Add(row);
                }

                worksheet.Cells.ImportData(dataTable, 0, 0, null);
                        
                workbook.Save( $"C:/Users/user/RiderProjects/RADIndividualTask/RADIndividualTask/MaterialReport.xlsx");
                Close();
            }
            else
            {
                error.Text = "Неправильно задан период!";
            }
        }
    }
}