using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RADIndividualTask.Models1;

namespace RADIndividualTask.Frames
{
    public partial class ProductFrame : Form
    {
        private bool _isAnyCellSelected;
        private int _selectedId;
        public ProductFrame()
        {
            InitializeComponent();
            UpdateView();
        }

        private void CheckSelection()
        {
            _isAnyCellSelected = false;
            
            for (int i = 0; i < productView.Rows.Count; i++)
            {
                for (int j = 0; j < productView.Rows[i].Cells.Count; j++)
                {
                    if (productView.Rows[i].Cells[j].Selected)
                    {
                        _selectedId = int.Parse(productView.Rows[i].Cells[4].Value.ToString());
                        _isAnyCellSelected = true;
                    }
                }
            }
        }
        
        private void UpdateView()
        {
            productView.Refresh();
            productView.DataSource = CRUD.Context.Products.ToList();
        
            materialsListField.Text = "";
            foreach (var material in CRUD.Context.Materials.ToList())
            {
                var unitsSum = material.CountUnits(out List<InputReport> reports);
                materialsListField.Text += $"{material.Id} - {material.Name}, кол-во: {unitsSum}\n";
            }
            
            error.Text = "";
        }

        private void AddProduct(object sender, EventArgs e)
        {
            var isUsedMaterialsExist = true;
            var materialIdsToCount = new Dictionary<int, double>();
            
            var ids = Array.ConvertAll(idsField.Text.Split(", "), x => int.Parse(x));
            var counts = Array.ConvertAll(countsField.Text.Split(", "), x => double.Parse(x));
            
            if (nameField.Text != "" && counts.Length == ids.Length) 
            {
                foreach (var id in ids)
                {
                    var material = CRUD.Context.Materials.Find(id);

                    if (material == null)
                    {
                        isUsedMaterialsExist = false;
                    }
                }

                if (isUsedMaterialsExist)
                {
                    for (int i = 0; i < ids.Length; i++)
                    {
                        var unitsSum = CRUD.Context.Materials.Find(ids[i]).CountUnits(out List<InputReport> reports);
                        if (reports.Count != 0 && unitsSum >= counts[i])
                        {
                            materialIdsToCount.Add(ids[i], counts[i]);
                        }
                        else
                        {
                            error.Text = "Нет требуемого количества материалов на складе!";
                        }
                    }
                    
                    CRUD.Context.Products.Add<Product>(new Product(nameField.Text, materialIdsToCount));
                    UpdateView();
                }
                else
                {
                    error.Text = "Нет материалов с заданными номерами!";
                }
            }
            else
            {
                error.Text = "Неправильно введены данные!";
            }
        }

        private void RemoveProduct(object sender, EventArgs e)
        {
            CheckSelection();
            if (_isAnyCellSelected)
            {
                var productToRemove = CRUD.Context.Products.Find(_selectedId);
                var dependentReportsCount = CRUD.Context.OutputReports
                    .Where(report => report.ProductId == _selectedId).ToList().Count;
                if (dependentReportsCount == 0)
                {
                    CRUD.Context.Products.Remove<Product>(productToRemove);
                    UpdateView();
                }
                else
                {
                    error.Text = "Удалите зависимые накладные!";
                }
                
            }
            else
            {
                error.Text = "Выберите продукт для удаления!";
            }
        }
        
        private void CloseFrame(object sender, EventArgs e)
        {
            Close();
        }
    }
}