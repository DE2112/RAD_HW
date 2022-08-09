using System.ComponentModel;

namespace RADIndividualTask.Frames
{
    partial class ProductFrame
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
            this.removeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.productView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.materialsListField = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idsField = new System.Windows.Forms.TextBox();
            this.countsField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.productView)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(12, 326);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(500, 64);
            this.error.TabIndex = 19;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(684, 396);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(104, 44);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveProduct);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(532, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "Номера материалов:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(532, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название:";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(617, 12);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(171, 22);
            this.nameField.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(532, 396);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 44);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddProduct);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 394);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(104, 44);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Назад";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseFrame);
            // 
            // productView
            // 
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView.Location = new System.Drawing.Point(12, 12);
            this.productView.Name = "productView";
            this.productView.RowTemplate.Height = 24;
            this.productView.Size = new System.Drawing.Size(500, 311);
            this.productView.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(532, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Кол-ва:";
            // 
            // materialsListField
            // 
            this.materialsListField.Location = new System.Drawing.Point(536, 164);
            this.materialsListField.Name = "materialsListField";
            this.materialsListField.Size = new System.Drawing.Size(252, 226);
            this.materialsListField.TabIndex = 22;
            this.materialsListField.Text = "";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(532, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Целые числа, через запятую";
            // 
            // idsField
            // 
            this.idsField.Location = new System.Drawing.Point(630, 53);
            this.idsField.Name = "idsField";
            this.idsField.Size = new System.Drawing.Size(158, 22);
            this.idsField.TabIndex = 24;
            // 
            // countsField
            // 
            this.countsField.Location = new System.Drawing.Point(630, 102);
            this.countsField.Name = "countsField";
            this.countsField.Size = new System.Drawing.Size(158, 22);
            this.countsField.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(532, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 34);
            this.label5.TabIndex = 26;
            this.label5.Text = "Вещественные числа с точкой, через запятую";
            // 
            // ProductFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countsField);
            this.Controls.Add(this.idsField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialsListField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.error);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.productView);
            this.Name = "ProductFrame";
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize) (this.productView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox idsField;
        private System.Windows.Forms.TextBox countsField;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.TextBox materialNumbers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.RichTextBox materialsListField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView productView;

        #endregion
    }
}