namespace RADIndividualTask.Frames
{
    partial class InputReportsFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.invoiceView = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.invoiceView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceView
            // 
            this.invoiceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceView.Location = new System.Drawing.Point(0, 0);
            this.invoiceView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceView.Name = "invoiceView";
            this.invoiceView.RowHeadersWidth = 51;
            this.invoiceView.Size = new System.Drawing.Size(1051, 630);
            this.invoiceView.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(574, 634);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(155, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddReport);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(735, 634);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(155, 30);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить запись";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.UpdateReport);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(896, 634);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(155, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteReport);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 634);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(155, 30);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.CloseFrame);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(173, 634);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(190, 30);
            this.exportButton.TabIndex = 5;
            this.exportButton.Text = "Экспортировать в Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportInvoices);
            // 
            // InputReportsFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 675);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.invoiceView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputReportsFrame";
            this.Text = "Входная накладная";
            ((System.ComponentModel.ISupportInitialize) (this.invoiceView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button exportButton;

        private System.Windows.Forms.Button buttonClose;

        #endregion

        private System.Windows.Forms.DataGridView invoiceView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}