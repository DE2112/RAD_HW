
namespace RADIndividualTask.Frames
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.providerAdd = new System.Windows.Forms.Button();
            this.addMaterial = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.showInputReportsButton = new System.Windows.Forms.Button();
            this.showOutputReportsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // providerAdd
            // 
            this.providerAdd.Location = new System.Drawing.Point(12, 12);
            this.providerAdd.Name = "providerAdd";
            this.providerAdd.Size = new System.Drawing.Size(112, 47);
            this.providerAdd.TabIndex = 0;
            this.providerAdd.Text = "Добавить поставщика";
            this.providerAdd.UseVisualStyleBackColor = true;
            this.providerAdd.Click += new System.EventHandler(this.AddProvider);
            // 
            // addMaterial
            // 
            this.addMaterial.Location = new System.Drawing.Point(12, 65);
            this.addMaterial.Name = "addMaterial";
            this.addMaterial.Size = new System.Drawing.Size(112, 47);
            this.addMaterial.TabIndex = 1;
            this.addMaterial.Text = "Добавить материал";
            this.addMaterial.UseVisualStyleBackColor = true;
            this.addMaterial.Click += new System.EventHandler(this.AddMaterial);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(12, 118);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(112, 47);
            this.addProduct.TabIndex = 2;
            this.addProduct.Text = "Добавить товар";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.AddProduct);
            // 
            // showInputReportsButton
            // 
            this.showInputReportsButton.Location = new System.Drawing.Point(12, 171);
            this.showInputReportsButton.Name = "showInputReportsButton";
            this.showInputReportsButton.Size = new System.Drawing.Size(112, 61);
            this.showInputReportsButton.TabIndex = 3;
            this.showInputReportsButton.Text = "Открыть входные накладные";
            this.showInputReportsButton.UseVisualStyleBackColor = true;
            this.showInputReportsButton.Click += new System.EventHandler(this.ShowInputReports);
            // 
            // showOutputReportsButton
            // 
            this.showOutputReportsButton.Location = new System.Drawing.Point(12, 238);
            this.showOutputReportsButton.Name = "showOutputReportsButton";
            this.showOutputReportsButton.Size = new System.Drawing.Size(112, 61);
            this.showOutputReportsButton.TabIndex = 4;
            this.showOutputReportsButton.Text = "Открыть расходные накладные";
            this.showOutputReportsButton.UseVisualStyleBackColor = true;
            this.showOutputReportsButton.Click += new System.EventHandler(this.ShowOutputReports);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отчет по поставщикам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeProvidersReport);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отчет по материалам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MakeMaterialsReport);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showOutputReportsButton);
            this.Controls.Add(this.showInputReportsButton);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.addMaterial);
            this.Controls.Add(this.providerAdd);
            this.Name = "MainFrame";
            this.Text = "Main";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button showOutputReportsButton;

        private System.Windows.Forms.Button showInputReportsButton;

        private System.Windows.Forms.Button addProduct;

        private System.Windows.Forms.Button addMaterial;

        private System.Windows.Forms.Button providerAdd;

        #endregion
    }
}