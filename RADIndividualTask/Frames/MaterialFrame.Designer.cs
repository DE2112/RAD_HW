using System.ComponentModel;

namespace RADIndividualTask.Frames
{
    partial class MaterialFrame
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
            this.materialView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.providerIdField = new System.Windows.Forms.NumericUpDown();
            this.providersListField = new System.Windows.Forms.RichTextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.materialView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.providerIdField)).BeginInit();
            this.SuspendLayout();
            // 
            // materialView
            // 
            this.materialView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialView.Location = new System.Drawing.Point(12, 12);
            this.materialView.Name = "materialView";
            this.materialView.RowTemplate.Height = 24;
            this.materialView.Size = new System.Drawing.Size(500, 311);
            this.materialView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 394);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(104, 44);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Назад";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseFrame);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(532, 396);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 44);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddMaterial);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(617, 12);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(171, 22);
            this.nameField.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(532, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(532, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер поставщика:";
            // 
            // providerIdField
            // 
            this.providerIdField.Location = new System.Drawing.Point(630, 53);
            this.providerIdField.Name = "providerIdField";
            this.providerIdField.Size = new System.Drawing.Size(50, 22);
            this.providerIdField.TabIndex = 6;
            // 
            // providersListField
            // 
            this.providersListField.Location = new System.Drawing.Point(532, 81);
            this.providersListField.Name = "providersListField";
            this.providersListField.Size = new System.Drawing.Size(256, 309);
            this.providersListField.TabIndex = 7;
            this.providersListField.Text = "";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(684, 396);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(104, 44);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveMaterial);
            // 
            // error
            // 
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(12, 326);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(500, 64);
            this.error.TabIndex = 9;
            // 
            // MaterialFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.providersListField);
            this.Controls.Add(this.providerIdField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.materialView);
            this.Name = "MaterialFrame";
            this.Text = "Материалы";
            ((System.ComponentModel.ISupportInitialize) (this.materialView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.providerIdField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button removeButton;

        private System.Windows.Forms.NumericUpDown providerIdField;

        private System.Windows.Forms.DataGridView materialView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox providersListField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label error;

        #endregion
    }
}