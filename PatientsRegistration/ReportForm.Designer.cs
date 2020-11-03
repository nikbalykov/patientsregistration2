namespace PatientsRegistration
{
    partial class ReportForm
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
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.surgeryRadioButton = new System.Windows.Forms.RadioButton();
            this.therapyRadioButton = new System.Windows.Forms.RadioButton();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Location = new System.Drawing.Point(249, 51);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(44, 17);
            this.allRadioButton.TabIndex = 0;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "Все";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // surgeryRadioButton
            // 
            this.surgeryRadioButton.AutoSize = true;
            this.surgeryRadioButton.Location = new System.Drawing.Point(249, 109);
            this.surgeryRadioButton.Name = "surgeryRadioButton";
            this.surgeryRadioButton.Size = new System.Drawing.Size(72, 17);
            this.surgeryRadioButton.TabIndex = 1;
            this.surgeryRadioButton.TabStop = true;
            this.surgeryRadioButton.Text = "Хирургия";
            this.surgeryRadioButton.UseVisualStyleBackColor = true;
            // 
            // therapyRadioButton
            // 
            this.therapyRadioButton.AutoSize = true;
            this.therapyRadioButton.Location = new System.Drawing.Point(249, 165);
            this.therapyRadioButton.Name = "therapyRadioButton";
            this.therapyRadioButton.Size = new System.Drawing.Size(68, 17);
            this.therapyRadioButton.TabIndex = 2;
            this.therapyRadioButton.TabStop = true;
            this.therapyRadioButton.Text = "Терапия";
            this.therapyRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(87, 109);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.yearNumericUpDown.TabIndex = 3;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.Location = new System.Drawing.Point(87, 51);
            this.monthNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNumericUpDown.Name = "monthNumericUpDown";
            this.monthNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.monthNumericUpDown.TabIndex = 4;
            this.monthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(87, 245);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(249, 245);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Месяц";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.monthNumericUpDown);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.therapyRadioButton);
            this.Controls.Add(this.surgeryRadioButton);
            this.Controls.Add(this.allRadioButton);
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.Text = "Формирование отчета";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.RadioButton allRadioButton;
        protected internal System.Windows.Forms.RadioButton surgeryRadioButton;
        protected internal System.Windows.Forms.RadioButton therapyRadioButton;
        protected internal System.Windows.Forms.NumericUpDown yearNumericUpDown;
        protected internal System.Windows.Forms.NumericUpDown monthNumericUpDown;
        protected internal System.Windows.Forms.Button okButton;
        protected internal System.Windows.Forms.Button cancelButton;
    }
}