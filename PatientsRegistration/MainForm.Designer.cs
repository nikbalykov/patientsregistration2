namespace PatientsRegistration
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calculatesDataGridView = new System.Windows.Forms.DataGridView();
            this.valuesDataGridView = new System.Windows.Forms.DataGridView();
            this.controlLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.refreshButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.deleteMonthButton = new System.Windows.Forms.Button();
            this.createNewMonthButton = new System.Windows.Forms.Button();
            this.dataLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculatesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuesDataGridView)).BeginInit();
            this.controlLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutPanel
            // 
            this.dataLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLayoutPanel.ColumnCount = 2;
            this.dataLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.22628F));
            this.dataLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.77372F));
            this.dataLayoutPanel.Controls.Add(this.calculatesDataGridView, 0, 0);
            this.dataLayoutPanel.Controls.Add(this.valuesDataGridView, 0, 0);
            this.dataLayoutPanel.Location = new System.Drawing.Point(0, 94);
            this.dataLayoutPanel.Name = "dataLayoutPanel";
            this.dataLayoutPanel.RowCount = 1;
            this.dataLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataLayoutPanel.Size = new System.Drawing.Size(1370, 519);
            this.dataLayoutPanel.TabIndex = 3;
            // 
            // calculatesDataGridView
            // 
            this.calculatesDataGridView.AllowUserToAddRows = false;
            this.calculatesDataGridView.AllowUserToDeleteRows = false;
            this.calculatesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculatesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calculatesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calculatesDataGridView.Location = new System.Drawing.Point(924, 3);
            this.calculatesDataGridView.MultiSelect = false;
            this.calculatesDataGridView.Name = "calculatesDataGridView";
            this.calculatesDataGridView.RowHeadersWidth = 50;
            this.calculatesDataGridView.Size = new System.Drawing.Size(443, 513);
            this.calculatesDataGridView.TabIndex = 3;
            // 
            // valuesDataGridView
            // 
            this.valuesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.valuesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valuesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.valuesDataGridView.Name = "valuesDataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.valuesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.NullValue = "0";
            this.valuesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.valuesDataGridView.Size = new System.Drawing.Size(915, 513);
            this.valuesDataGridView.TabIndex = 2;
            // 
            // controlLayoutPanel
            // 
            this.controlLayoutPanel.AutoSize = true;
            this.controlLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlLayoutPanel.ColumnCount = 6;
            this.controlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlLayoutPanel.Controls.Add(this.monthLabel, 0, 0);
            this.controlLayoutPanel.Controls.Add(this.yearNumericUpDown, 1, 1);
            this.controlLayoutPanel.Controls.Add(this.refreshButton, 2, 0);
            this.controlLayoutPanel.Controls.Add(this.reportButton, 5, 0);
            this.controlLayoutPanel.Controls.Add(this.yearLabel, 0, 1);
            this.controlLayoutPanel.Controls.Add(this.monthNumericUpDown, 1, 0);
            this.controlLayoutPanel.Controls.Add(this.saveChangesButton, 2, 1);
            this.controlLayoutPanel.Controls.Add(this.addRecordButton, 4, 0);
            this.controlLayoutPanel.Controls.Add(this.deleteRecordButton, 4, 1);
            this.controlLayoutPanel.Controls.Add(this.deleteMonthButton, 3, 1);
            this.controlLayoutPanel.Controls.Add(this.createNewMonthButton, 3, 0);
            this.controlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.controlLayoutPanel.Name = "controlLayoutPanel";
            this.controlLayoutPanel.RowCount = 2;
            this.controlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.controlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.controlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlLayoutPanel.Size = new System.Drawing.Size(1370, 88);
            this.controlLayoutPanel.TabIndex = 11;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(10, 10);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(10);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Месяц";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(70, 54);
            this.yearNumericUpDown.Margin = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.yearNumericUpDown.TabIndex = 11;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(195, 10);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.refreshButton.MaximumSize = new System.Drawing.Size(200, 25);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(200, 23);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // reportButton
            // 
            this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportButton.Location = new System.Drawing.Point(1098, 10);
            this.reportButton.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.reportButton.MaximumSize = new System.Drawing.Size(200, 25);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(200, 23);
            this.reportButton.TabIndex = 17;
            this.reportButton.Text = "Сформировать отчёт";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(10, 54);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(10);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(25, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Год";
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.Location = new System.Drawing.Point(70, 10);
            this.monthNumericUpDown.Margin = new System.Windows.Forms.Padding(10, 10, 30, 10);
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
            this.monthNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.monthNumericUpDown.TabIndex = 18;
            this.monthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChangesButton.Location = new System.Drawing.Point(195, 54);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.saveChangesButton.MaximumSize = new System.Drawing.Size(200, 25);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(200, 23);
            this.saveChangesButton.TabIndex = 14;
            this.saveChangesButton.Text = "Сохранить изменения";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // addRecordButton
            // 
            this.addRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRecordButton.Location = new System.Drawing.Point(797, 10);
            this.addRecordButton.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.addRecordButton.MaximumSize = new System.Drawing.Size(200, 25);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(200, 23);
            this.addRecordButton.TabIndex = 15;
            this.addRecordButton.Text = "Добавить запись";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click_1);
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRecordButton.Location = new System.Drawing.Point(797, 54);
            this.deleteRecordButton.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.deleteRecordButton.MaximumSize = new System.Drawing.Size(200, 25);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(200, 23);
            this.deleteRecordButton.TabIndex = 6;
            this.deleteRecordButton.Text = "Удалить запись";
            this.deleteRecordButton.UseVisualStyleBackColor = true;
            this.deleteRecordButton.Click += new System.EventHandler(this.deleteRecordButton_Click);
            // 
            // deleteMonthButton
            // 
            this.deleteMonthButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteMonthButton.Location = new System.Drawing.Point(496, 54);
            this.deleteMonthButton.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.deleteMonthButton.MaximumSize = new System.Drawing.Size(200, 25);
            this.deleteMonthButton.Name = "deleteMonthButton";
            this.deleteMonthButton.Size = new System.Drawing.Size(200, 23);
            this.deleteMonthButton.TabIndex = 16;
            this.deleteMonthButton.Text = "Удалить данные за месяц";
            this.deleteMonthButton.UseVisualStyleBackColor = true;
            // 
            // createNewMonthButton
            // 
            this.createNewMonthButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createNewMonthButton.Location = new System.Drawing.Point(496, 10);
            this.createNewMonthButton.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.createNewMonthButton.MaximumSize = new System.Drawing.Size(200, 25);
            this.createNewMonthButton.Name = "createNewMonthButton";
            this.createNewMonthButton.Size = new System.Drawing.Size(200, 23);
            this.createNewMonthButton.TabIndex = 13;
            this.createNewMonthButton.Text = "Начать новый месяц";
            this.createNewMonthButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 616);
            this.Controls.Add(this.controlLayoutPanel);
            this.Controls.Add(this.dataLayoutPanel);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Учет движения больных и коечного фонда (версия 2.0)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dataLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculatesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuesDataGridView)).EndInit();
            this.controlLayoutPanel.ResumeLayout(false);
            this.controlLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel dataLayoutPanel;
        private System.Windows.Forms.DataGridView calculatesDataGridView;
        private System.Windows.Forms.DataGridView valuesDataGridView;
        private System.Windows.Forms.TableLayoutPanel controlLayoutPanel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button createNewMonthButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button deleteMonthButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.NumericUpDown monthNumericUpDown;
    }
}