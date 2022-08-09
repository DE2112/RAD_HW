using RADIndividualTask.Models1;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RADIndividualTask.Frames
{
    public partial class ProviderFrame : Form
    {
        private bool _isAnyCellSelected;
        private int _selectedId;
        public ProviderFrame()
        {
            InitializeComponent();
            UpdateView();
        }

        private void CheckSelection()
        {
            _isAnyCellSelected = false;
            
            for (int i = 0; i < providerView.Rows.Count; i++)
            {
                for (int j = 0; j < providerView.Rows[i].Cells.Count; j++)
                {
                    if (providerView.Rows[i].Cells[j].Selected)
                    {
                        _selectedId = int.Parse(providerView.Rows[i].Cells[3].Value.ToString());
                        _isAnyCellSelected = true;
                    }
                }
            }
        }

        private void AddProvider(object sender, EventArgs e)
        {
            if (providerNameField.Text != "")
            {
                CRUD.Context.Providers.Add<Provider>(new Provider(providerNameField.Text));
                UpdateView();
            }
            else
            {
                error.Text = "Введите название поставщика!";
            }
        }

        private void RemoveProvider(object sender, EventArgs e)
        {
            CheckSelection();
            if (_isAnyCellSelected)
            {
                var providerToRemove = CRUD.Context.Providers.Find(_selectedId);
                var providedMaterialTypesCount = CRUD.Context.Materials
                    .Where(material => material.ProviderId == _selectedId).ToList().Count;
                if (providedMaterialTypesCount == 0)
                {
                    CRUD.Context.Providers.Remove<Provider>(providerToRemove);
                    UpdateView();
                }
                else
                {
                    error.Text = "Удалите зависимые материалы!";
                }
                
            }
            else
            {
                error.Text = "Выберите поставщика для удаления!";
            }
        }

        private void UpdateView()
        {
            providerView.Refresh();
            providerView.DataSource = CRUD.Context.Providers.ToList();
            error.Text = "";
        }

        private void CloseFrame(object sender, EventArgs e)
        {
            Close();
        }
    }
}