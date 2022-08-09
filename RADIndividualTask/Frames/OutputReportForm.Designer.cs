using System.ComponentModel;

namespace RADIndividualTask.Frames
{
    partial class OutputReportForm
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
            this.error = new System.Windows.Forms.Label();
            this.productsListField = new System.Windows.Forms.RichTextBox();
            this.productIdField = new System.Windows.Forms.NumericUpDown();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pricePerUnitField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.productIdField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.countField)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(9, 282);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(321, 82);
            this.error.TabIndex = 31;
            // 
            // productsListField
            // 
            this.productsListField.Location = new System.Drawing.Point(12, 32);
            this.productsListField.Name = "productsListField";
            this.productsListField.Size = new System.Drawing.Size(321, 247);
            this.productsListField.TabIndex = 30;
            this.productsListField.Text = "";
            // 
            // productIdField
            // 
            this.productIdField.Location = new System.Drawing.Point(149, 4);
            this.productIdField.Name = "productIdField";
            this.productIdField.Size = new System.Drawing.Size(120, 22);
            this.productIdField.TabIndex = 29;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(134, 451);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(114, 34);
            this.closeButton.TabIndex = 27;
            this.closeButton.Text = "Назад";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseFrame);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(14, 451);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 34);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveProduct);
            // 
            // dateField
            // 
            this.dateField.Location = new System.Drawing.Point(151, 420);
            this.dateField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(184, 22);
            this.dateField.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Дата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Цена за единицу:";
            // 
            // pricePerUnitField
            // 
            this.pricePerUnitField.Location = new System.Drawing.Point(151, 394);
            this.pricePerUnitField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricePerUnitField.Name = "pricePerUnitField";
            this.pricePerUnitField.Size = new System.Drawing.Size(150, 22);
            this.pricePerUnitField.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Номер товара:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Кол-во товара:";
            // 
            // countField
            // 
            this.countField.Location = new System.Drawing.Point(151, 367);
            this.countField.Name = "countField";
            this.countField.Size = new System.Drawing.Size(120, 22);
            this.countField.TabIndex = 32;
            // 
            // OutputReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 495);
            this.Controls.Add(this.countField);
            this.Controls.Add(this.error);
            this.Controls.Add(this.productsListField);
            this.Controls.Add(this.productIdField);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricePerUnitField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OutputReportForm";
            ((System.ComponentModel.ISupportInitialize) (this.productIdField)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.countField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown productIdField;

        private System.Windows.Forms.NumericUpDown countField;

        private System.Windows.Forms.Label error;
        private System.Windows.Forms.RichTextBox productsListField;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricePerUnitField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}