using System;
using System.Linq;
using System.Windows.Forms;
using RADIndividualTask.Models1;

namespace RADIndividualTask.Frames
{
    public partial class MaterialFrame : Form
    {
        private bool _isAnyCellSelected;
        private int _selectedId;
        public MaterialFrame()
        {
            InitializeComponent();
            UpdateView();
        }

        private void CheckSelection()
        {
            _isAnyCellSelected = false;
            
            for (int i = 0; i < materialView.Rows.Count; i++)
            {
                for (int j = 0; j < materialView.Rows[i].Cells.Count; j++)
                {
                    if (materialView.Rows[i].Cells[j].Selected)
                    {
                        _selectedId = int.Parse(materialView.Rows[i].Cells[4].Value.ToString());
                        _isAnyCellSelected = true;
                    }
                }
            }
        }

        private void UpdateView()
        {
            materialView.Refresh();
            materialView.DataSource = CRUD.Context.Materials.ToList();

            providersListField.Text = "";
            foreach (var provider in CRUD.Context.Providers.ToList())
            {
                providersListField.Text += $"{provider.Id} - {provider.Name}\n";
            }
            
            error.Text = "";
        }

        private void CloseFrame(object sender, EventArgs e)
        {
            Close();
        }

        private void AddMaterial(object sender, EventArgs e)
        {
            var providerId = (int) providerIdField.Value;
            if (nameField.Text != "" && CRUD.Context.Providers.Find(providerId) != null)
            {
                CRUD.Context.Materials.Add<Material>(new Material(nameField.Text, providerId));
                UpdateView();
            }
            else
            {
                error.Text = "Введите данные правильно!";
            }
        }

        private void RemoveMaterial(object sender, EventArgs e)
        {
            CheckSelection();
            if (_isAnyCellSelected)
            {
                var materialToRemove = CRUD.Context.Materials.Find(_selectedId);
                // var productTypesCount = CRUD.Context.Products
                //     .Where(product => product.GetMaterials().Keys.Contains(_selectedId)).ToList().Count;
                
                var dependentReportsCount = CRUD.Context.InputReports
                    .Where(report => report.MaterialId == _selectedId).ToList().Count;
                if (dependentReportsCount == 0)
                {
                    CRUD.Context.Materials.Remove<Material>(materialToRemove);
                    UpdateView();
                }
                else
                {
                    error.Text = "Удалите зависимые продукты и/или накладные!";
                }
                
            }
            else
            {
                error.Text = "Выберите материал для удаления!";
            }
        }
    }
}