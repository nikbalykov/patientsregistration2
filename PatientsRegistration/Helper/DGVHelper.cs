using System;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;

namespace PatientsRegistration.Helper
{
    public class DGVHelper
    {
        public static void ConfigureColumnsForData(DataGridView dataGridView)
        {
            dataGridView.Columns[5].HeaderText = "Наименование";
            dataGridView.Columns[6].HeaderText = "Группа отделений";
            dataGridView.Columns[7].HeaderText = "Число коек";
            dataGridView.Columns[8].HeaderText = "Состояло";
            dataGridView.Columns[9].HeaderText = "Поступило всего";
            dataGridView.Columns[10].HeaderText = "В т.ч. сельских";
            dataGridView.Columns[11].HeaderText = "Переведено из др";
            dataGridView.Columns[12].HeaderText = "Переведено в др";
            dataGridView.Columns[13].HeaderText = "Выписано";
            dataGridView.Columns[14].HeaderText = "Умерло";
            dataGridView.Columns[15].HeaderText = "Состоит";
            dataGridView.Columns[16].HeaderText = "План к/дн";
            dataGridView.Columns[17].HeaderText = "Факт к/дн";
            dataGridView.Columns[18].HeaderText = "К/дн сельских";
            for (int i = 0; i < 5; i++)
                dataGridView.Columns[i].Visible = false;
        }

        public static void ConfigureColumnsForCalculates(DataGridView dataGridView)
        {
            dataGridView.Columns[19].HeaderText = "% выполнения плана";
            dataGridView.Columns[20].HeaderText = "Летальность";
            dataGridView.Columns[21].HeaderText = "Среднее пребывание";
            dataGridView.Columns[22].HeaderText = "Работа койки";
            dataGridView.Columns[23].HeaderText = "Оборот койки";
            dataGridView.Columns[24].HeaderText = "% сельских жителей";
            for (int i  = 0; i < 19; i++)
                dataGridView.Columns[i].Visible = false;
        }

        public static void ConfigureHeadersHeight(DataGridView dataGridView1, DataGridView dataGridView2)
        {
            int first = dataGridView1.ColumnHeadersHeight;
            int second = dataGridView2.ColumnHeadersHeight;
            dataGridView1.ColumnHeadersHeight = Math.Max(first, second);
            dataGridView2.ColumnHeadersHeight = Math.Max(first, second);
        }
    }
}
