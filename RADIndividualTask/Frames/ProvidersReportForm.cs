using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Aspose.Cells;

namespace RADIndividualTask.Frames
{
    public partial class ProvidersReportForm : Form
    {
        public ProvidersReportForm()
        {
            InitializeComponent();

            providersListField.Text = "";
            foreach (var provider in CRUD.Context.Providers)
            {
                providersListField.Text += $"{provider.Id} - {provider.Name}\n";
            }
        }

        private void MakeReport(object sender, EventArgs e)
        {
            error.Text = "";
            var fromDate = fromDateField.Value;
            var toDate = toDateField.Value;
            
            if (providerIdsField.Text != "")
            {
                var isIntegers = Array.ConvertAll(providerIdsField.Text.Split(", "), x => int.TryParse(x, out var a));

                if (!isIntegers.Contains(false))
                {
                    var ids = Array.ConvertAll(providerIdsField.Text.Split(", "), x => int.Parse(x));

                    if (fromDate < toDate)
                    {
                        var workbook = new Workbook();
                        var worksheet = workbook.Worksheets[0];
            
                        var dataTable = new DataTable("ProviderReport");
                        dataTable.Columns.Add("ID", typeof(int));
                        dataTable.Columns.Add("Наименование поставщика", typeof(string));
                        dataTable.Columns.Add("Поставлено материалов на", typeof(double));
                        dataTable.Columns.Add("Долг", typeof(double));

                        foreach (var id in ids)
                        {
                            var provider = CRUD.Context.Providers.Find(id);
                            
                            var row = dataTable.NewRow();
                            row[0] = provider.Id;
                            row[1] = provider.Name;

                            var targetReports = CRUD.Context.InputReports.ToList()
                                .Where(report => report.Material.ProviderId == provider.Id && report.Date.IsInRange(fromDate, toDate)).ToList();
                            
                            row[2] = targetReports.Sum(report => report.TotalCost);
                            row[3] = targetReports.Sum(report => report.TotalCost - report.Paid);
                            dataTable.Rows.Add(row);
                        }

                        worksheet.Cells.ImportData(dataTable, 0, 0, null);
                        
                        workbook.Save( $"C:/Users/user/RiderProjects/RADIndividualTask/RADIndividualTask/ProviderReport.xlsx");
                        Close();
                    }
                    else
                    {
                        error.Text = "Неправильно задан период!";
                    }
                }
                else
                {
                    error.Text = "Неправильный ввод!";
                }
            }
            else
            {
                error.Text = "Заполните поле индексов!";
            }
        }
        
        

        private void CloseFrame(object sender, EventArgs e)
        {
            Close();
        }
    }
}