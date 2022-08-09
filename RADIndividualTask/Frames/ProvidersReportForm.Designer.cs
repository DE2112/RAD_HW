using System.ComponentModel;

namespace RADIndividualTask.Frames
{
    partial class ProvidersReportForm
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
            this.providerIdsField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.providersListField = new System.Windows.Forms.RichTextBox();
            this.error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDateField = new System.Windows.Forms.DateTimePicker();
            this.toDateField = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // providerIdsField
            // 
            this.providerIdsField.Location = new System.Drawing.Point(111, 29);
            this.providerIdsField.Name = "providerIdsField";
            this.providerIdsField.Size = new System.Drawing.Size(222, 22);
            this.providerIdsField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номера поставщиков:";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Целые числа, через запятую";
            // 
            // providersListField
            // 
            this.providersListField.Location = new System.Drawing.Point(15, 86);
            this.providersListField.Name = "providersListField";
            this.providersListField.Size = new System.Drawing.Size(318, 141);
            this.providersListField.TabIndex = 3;
            this.providersListField.Text = "";
            // 
            // error
            // 
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(15, 230);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(321, 73);
            this.error.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "От:";
            // 
            // fromDateField
            // 
            this.fromDateField.Location = new System.Drawing.Point(54, 298);
            this.fromDateField.Name = "fromDateField";
            this.fromDateField.Size = new System.Drawing.Size(200, 22);
            this.fromDateField.TabIndex = 6;
            // 
            // toDateField
            // 
            this.toDateField.Location = new System.Drawing.Point(54, 326);
            this.toDateField.Name = "toDateField";
            this.toDateField.Size = new System.Drawing.Size(200, 22);
            this.toDateField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "До:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Составить отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeReport);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseFrame);
            // 
            // ProvidersReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDateField);
            this.Controls.Add(this.fromDateField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.error);
            this.Controls.Add(this.providersListField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.providerIdsField);
            this.Name = "ProvidersReportForm";
            this.Text = "Отчет по поставщикам";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox providerIdsField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox providersListField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DateTimePicker fromDateField;
        private System.Windows.Forms.DateTimePicker toDateField;
        


        #endregion
    }
}