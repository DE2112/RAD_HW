using System.ComponentModel;

namespace RADIndividualTask.Frames
{
    partial class MaterialReportForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toDateField = new System.Windows.Forms.DateTimePicker();
            this.fromDateField = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseFrame);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Составить отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeReport);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "До:";
            // 
            // toDateField
            // 
            this.toDateField.Location = new System.Drawing.Point(51, 105);
            this.toDateField.Name = "toDateField";
            this.toDateField.Size = new System.Drawing.Size(200, 22);
            this.toDateField.TabIndex = 14;
            // 
            // fromDateField
            // 
            this.fromDateField.Location = new System.Drawing.Point(51, 77);
            this.fromDateField.Name = "fromDateField";
            this.fromDateField.Size = new System.Drawing.Size(200, 22);
            this.fromDateField.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "От:";
            // 
            // error
            // 
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(12, 9);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(321, 73);
            this.error.TabIndex = 11;
            // 
            // MaterialReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 225);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDateField);
            this.Controls.Add(this.fromDateField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.error);
            this.Name = "MaterialReportForm";
            this.Text = "Отчет по движению материалов";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker toDateField;
        private System.Windows.Forms.DateTimePicker fromDateField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error;

        #endregion
    }
}