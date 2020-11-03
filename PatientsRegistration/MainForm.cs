using PatientsRegistration.Helper;
using PatientsRegistration.Service;
using System;
using System.Windows.Forms;

namespace PatientsRegistration
{
    public partial class MainForm : Form
    {
        RecordContext db;
        RecordService recordService;

        public MainForm()
        {
            InitializeComponent();

            db = new RecordContext();
            recordService = new RecordService(db);
        }

        private void RefreshData()
        {
            using (RecordContext db = new RecordContext())
            {
                int month = Convert.ToInt32(monthNumericUpDown.Value);
                int year = Convert.ToInt32(yearNumericUpDown.Value);
                valuesDataGridView.DataSource = recordService.GetRecordDtoList(month, year);
                calculatesDataGridView.DataSource = recordService.GetRecordFullDtoList(month, year);
            }

            DGVHelper.ConfigureColumnsForData(valuesDataGridView);
            DGVHelper.ConfigureColumnsForCalculates(calculatesDataGridView);
            DGVHelper.ConfigureHeadersHeight(valuesDataGridView, calculatesDataGridView);
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void addRecordButton_Click_1(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(monthNumericUpDown.Value);
            int year = Convert.ToInt32(yearNumericUpDown.Value);

            AddForm addForm = new AddForm();
            addForm.parentNameComboBox.Items.AddRange(recordService.GetParentList(month, year));
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Record record = new Record();
            record.Year = year;
            record.Month = month;
            record.Name = addForm.nameTextBox.Text;
            record.BedCount = Convert.ToDouble(addForm.bedCountTextBox.Text);
            record.Consisted = Convert.ToDouble(addForm.consistedTextBox.Text);
            record.Received = Convert.ToDouble(addForm.receivedTextBox.Text);
            record.Rural = Convert.ToDouble(addForm.ruralTextBox.Text);
            record.RelocatedFrom = Convert.ToDouble(addForm.relocatedFromTextBox.Text);
            record.RelocatedTo = Convert.ToDouble(addForm.relocatedToTextBox.Text);
            record.Discharged = Convert.ToDouble(addForm.dischargedTextBox.Text);
            record.Died = Convert.ToDouble(addForm.diedTextBox.Text);
            record.Consist = Convert.ToDouble(addForm.consistTextBox.Text);
            record.PlanKdn = Convert.ToDouble(addForm.planKdnTextBox.Text);
            record.FactKdn = Convert.ToDouble(addForm.factKdnTextBox.Text);
            record.RuralKdn = Convert.ToDouble(addForm.ruralKdnTextBox.Text);

            string isParent = addForm.isParentComboBox.SelectedItem.ToString();
            if (isParent.Equals("Да"))
            {
                record.IsParent = true;
                record.ParentId = null;
            }
            else
            {
                record.IsParent = false;
                record.ParentId = Convert.ToString(recordService.FindRecordByName(addForm.parentNameComboBox.SelectedItem.ToString()));
            }

            string departmentGroup = addForm.departmentGroupComboBox.SelectedItem.ToString();
            if (departmentGroup.Equals("Терапия"))
            {
                record.DepartmentGroup = DepartmentGroup.Therapy;
            }
            else if (departmentGroup.Equals("Хирургия"))
            {
                record.DepartmentGroup = DepartmentGroup.Surgery;
            }
            else if (departmentGroup.Equals("Реанимация"))
            {
                record.DepartmentGroup = DepartmentGroup.Resuscitation;
            }
            else
            {
                record.DepartmentGroup = DepartmentGroup.DayHospital;
            }

            db.Records.Add(record);
            db.SaveChanges();

            RefreshData();

            MessageBox.Show("Запись добавлена");
        }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
            if (valuesDataGridView.SelectedRows.Count == 1)
            {
                int index = valuesDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(valuesDataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Record record = db.Records.Find(id);
                db.Records.Remove(record);
                db.SaveChanges();

                RefreshData();

                MessageBox.Show("Запись удалена.");
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            DialogResult result = reportForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            int month = Convert.ToInt32(reportForm.monthNumericUpDown.Value);
            int year = Convert.ToInt32(reportForm.yearNumericUpDown.Value);

            ExcelService excelService = new ExcelService();
            excelService.CreateReport(month, year);
        }
    }
}
