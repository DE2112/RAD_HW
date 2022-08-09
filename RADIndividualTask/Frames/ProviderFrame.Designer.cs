using System.ComponentModel;

namespace RADIndividualTask.Frames
{
    partial class ProviderFrame
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.providerView = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.providerNameField = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.providerView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(162, 460);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddProvider);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(669, 460);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(116, 36);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.RemoveProvider);
            // 
            // providerView
            // 
            this.providerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providerView.Location = new System.Drawing.Point(12, 10);
            this.providerView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.providerView.Name = "providerView";
            this.providerView.RowHeadersWidth = 51;
            this.providerView.RowTemplate.Height = 29;
            this.providerView.Size = new System.Drawing.Size(776, 370);
            this.providerView.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(9, 460);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(116, 36);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.CloseFrame);
            // 
            // providerNameField
            // 
            this.providerNameField.Location = new System.Drawing.Point(284, 467);
            this.providerNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.providerNameField.Name = "providerNameField";
            this.providerNameField.Size = new System.Drawing.Size(290, 22);
            this.providerNameField.TabIndex = 4;
            // 
            // error
            // 
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(9, 382);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(522, 23);
            this.error.TabIndex = 5;
            // 
            // ProviderAddFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.error);
            this.Controls.Add(this.providerNameField);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.providerView);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Name = "ProviderFrame";
            this.Text = "Поставщики";
            ((System.ComponentModel.ISupportInitialize) (this.providerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label error;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button buttonAdd;

        #endregion

        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridView providerView;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox providerNameField;
    }
}