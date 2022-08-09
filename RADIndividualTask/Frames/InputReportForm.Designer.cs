
namespace RADIndividualTask.Frames
{
    partial class InputReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costPerUnitField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paidField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.unitsField = new System.Windows.Forms.TextBox();
            this.materialIdField = new System.Windows.Forms.NumericUpDown();
            this.materialsListField = new System.Windows.Forms.RichTextBox();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.materialIdField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во материала (м):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер материала:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена за единицу:";
            // 
            // costPerUnitField
            // 
            this.costPerUnitField.Location = new System.Drawing.Point(151, 375);
            this.costPerUnitField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costPerUnitField.Name = "costPerUnitField";
            this.costPerUnitField.Size = new System.Drawing.Size(150, 22);
            this.costPerUnitField.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Оплачено:";
            // 
            // paidField
            // 
            this.paidField.Location = new System.Drawing.Point(151, 401);
            this.paidField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paidField.Name = "paidField";
            this.paidField.Size = new System.Drawing.Size(150, 22);
            this.paidField.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата:";
            // 
            // dateField
            // 
            this.dateField.Location = new System.Drawing.Point(151, 426);
            this.dateField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(184, 22);
            this.dateField.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(14, 457);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 34);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveProduct);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(134, 457);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(114, 34);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Назад";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseFrame);
            // 
            // unitsField
            // 
            this.unitsField.Location = new System.Drawing.Point(169, 349);
            this.unitsField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitsField.Name = "unitsField";
            this.unitsField.Size = new System.Drawing.Size(132, 22);
            this.unitsField.TabIndex = 14;
            // 
            // materialIdField
            // 
            this.materialIdField.Location = new System.Drawing.Point(149, 10);
            this.materialIdField.Name = "materialIdField";
            this.materialIdField.Size = new System.Drawing.Size(120, 22);
            this.materialIdField.TabIndex = 15;
            // 
            // materialsListField
            // 
            this.materialsListField.Location = new System.Drawing.Point(12, 38);
            this.materialsListField.Name = "materialsListField";
            this.materialsListField.Size = new System.Drawing.Size(321, 209);
            this.materialsListField.TabIndex = 16;
            this.materialsListField.Text = "";
            // 
            // error
            // 
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(12, 250);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(321, 97);
            this.error.TabIndex = 17;
            // 
            // InputReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 503);
            this.Controls.Add(this.error);
            this.Controls.Add(this.materialsListField);
            this.Controls.Add(this.materialIdField);
            this.Controls.Add(this.unitsField);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paidField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costPerUnitField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputReportForm";
            ((System.ComponentModel.ISupportInitialize) (this.materialIdField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown materialIdField;
        private System.Windows.Forms.RichTextBox materialsListField;

        private System.Windows.Forms.Label error;

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox materialListField;

        private System.Windows.Forms.TextBox unitsField;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costPerUnitField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paidField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
    }
}