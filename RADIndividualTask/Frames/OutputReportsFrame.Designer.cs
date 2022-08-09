using System.ComponentModel;

namespace RADIndividualTask.Frames
{
    partial class OutputReportsFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.invoiceView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.invoiceView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceView
            // 
            this.invoiceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceView.Location = new System.Drawing.Point(0, 0);
            this.invoiceView.Name = "invoiceView";
            this.invoiceView.RowTemplate.Height = 24;
            this.invoiceView.Size = new System.Drawing.Size(1051, 630);
            this.invoiceView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 636);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(155, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Назад";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseFrame);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(896, 636);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(155, 30);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Удалить запись";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveReport);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(735, 636);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(155, 30);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Изменить запись";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.UpdateReport);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(574, 636);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(155, 30);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddReport);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(173, 634);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(190, 30);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Экспортировать в Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportInvoices);
            // 
            // OutputReportsFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 675);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.invoiceView);
            this.Name = "OutputReportsFrame";
            this.Text = "Расходная накладная";
            ((System.ComponentModel.ISupportInitialize) (this.invoiceView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button exportButton;

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.DataGridView invoiceView;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}