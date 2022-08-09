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

namespace RADIndividualTask.Frames
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void AddProvider(object sender, EventArgs e)
        {
            var providerFrame = new ProviderFrame();
            providerFrame.Show();
        }

        private void AddMaterial(object sender, EventArgs e)
        {
            var materialFrame = new MaterialFrame();
            materialFrame.Show();
        }

        private void AddProduct(object sender, EventArgs e)
        {
            var productFrame = new ProductFrame();
            productFrame.Show();
        }

        private void ShowInputReports(object sender, EventArgs e)
        {
            var inputReportsFrame = new InputReportsFrame();
            inputReportsFrame.Show();
        }

        private void ShowOutputReports(object sender, EventArgs e)
        {
            var outputReportsFrame = new OutputReportsFrame();
            outputReportsFrame.Show();
        }
        
        private void MakeProvidersReport(object sender, EventArgs e)
        {
            var providersReportForm = new ProvidersReportForm();
            providersReportForm.Show();
        }

        private void MakeMaterialsReport(object sender, EventArgs e)
        {
            var materialReportForm = new MaterialReportForm();
            materialReportForm.Show();
        }
    }
}
