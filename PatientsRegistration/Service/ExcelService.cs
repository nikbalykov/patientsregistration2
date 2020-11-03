using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace PatientsRegistration.Service
{
    public class ExcelService
    {
        public void CreateReport(int month, int year)
        {
            Application application = new Application();

            Workbook workbook = application.Workbooks.Add();

            Worksheet worksheet = workbook.Worksheets.Item[1];

            worksheet.Cells[1, 1] = $"Сводная ведомость (за месяц) учета движения больных и коечного фонда по республиканской больнице им. Н.А.Семашко {month}.{year}";
            worksheet.get_Range("A1:AC1").Merge();
            worksheet.Cells[2, 1] = "Наименование";
            worksheet.get_Range("A2:A3").Merge();
            worksheet.Cells[2, 2] = "Число коек";
            worksheet.get_Range("B2:B3").Merge();
            worksheet.Cells[2, 3] = "Состояло";
            worksheet.get_Range("C2:C3").Merge();
            worksheet.Cells[2, 4] = "Поступило всего";
            worksheet.get_Range("D2:E2").Merge();
            worksheet.Cells[3, 4] = year - 1;
            worksheet.Cells[3, 5] = year;
            worksheet.Cells[2, 6] = "В т.ч. сельских";
            worksheet.get_Range("F2:G2").Merge();
            worksheet.Cells[3, 6] = year - 1;
            worksheet.Cells[3, 7] = year;
            worksheet.Cells[2, 8] = "Переведено";
            worksheet.get_Range("H2:I2").Merge();
            worksheet.Cells[3, 8] = "из др";
            worksheet.Cells[3, 9] = "в др";
            worksheet.Cells[2, 10] = "Выписано";
            worksheet.get_Range("J2:K2").Merge();
            worksheet.Cells[3, 10] = year - 1;
            worksheet.Cells[3, 11] = year;
            worksheet.Cells[2, 12] = "Умерло";
            worksheet.get_Range("L2:M2").Merge();
            worksheet.Cells[3, 12] = year - 1;
            worksheet.Cells[3, 13] = year;
            worksheet.Cells[2, 14] = "Состоит";
            worksheet.get_Range("N2:N3").Merge();
            worksheet.Cells[2, 15] = "План к/дн";
            worksheet.get_Range("O2:O3").Merge();
            worksheet.Cells[2, 16] = "Факт к/дн";
            worksheet.get_Range("P2:P3").Merge();
            worksheet.Cells[2, 17] = "К/дн сельских";
            worksheet.get_Range("Q2:Q3").Merge();
            worksheet.Cells[2, 18] = "% выполнения плана";
            worksheet.get_Range("R2:S2").Merge();
            worksheet.Cells[3, 18] = year - 1;
            worksheet.Cells[3, 19] = year;
            worksheet.Cells[2, 20] = "Летальность";
            worksheet.get_Range("T2:U2").Merge();
            worksheet.Cells[3, 20] = year - 1;
            worksheet.Cells[3, 21] = year;
            worksheet.Cells[2, 22] = "Среднее пребывание";
            worksheet.get_Range("V2:W2").Merge();
            worksheet.Cells[3, 22] = year - 1;
            worksheet.Cells[3, 23] = year;
            worksheet.Cells[2, 24] = "Работа койки";
            worksheet.get_Range("X2:Y2").Merge();
            worksheet.Cells[3, 24] = year - 1;
            worksheet.Cells[3, 25] = year;
            worksheet.Cells[2, 26] = "Оборот койки";
            worksheet.get_Range("Z2:AA2").Merge();
            worksheet.Cells[3, 26] = year - 1;
            worksheet.Cells[3, 27] = year;
            worksheet.Cells[2, 28] = "% сельских жителей";
            worksheet.get_Range("AB2:AC2").Merge();
            worksheet.Cells[3, 28] = year - 1;
            worksheet.Cells[3, 29] = year;

            RecordContext db = new RecordContext();
            RecordService recordService = new RecordService(db);

            List<RecordFullDto> records = recordService.GetRecordFullDtoList(month, year);
            List<RecordFullDto> recordsBefore = recordService.GetRecordFullDtoList(month, year - 1);
            List<string[]> fill = new List<string[]>();
            foreach(RecordFullDto record in records)
            {
                string[] fields = new string[29];
                fields[0] = record.Name;
                fields[1] = Convert.ToString(record.BedCount);
                fields[2] = Convert.ToString(record.Consisted);
                fields[4] = Convert.ToString(record.Received);
                fields[6] = Convert.ToString(record.Rural);
                fields[7] = Convert.ToString(record.RelocatedFrom);
                fields[8] = Convert.ToString(record.RelocatedTo);
                fields[10] = Convert.ToString(record.Discharged);
                fields[12] = Convert.ToString(record.Died);
                fields[13] = Convert.ToString(record.Consist);
                fields[14] = Convert.ToString(record.PlanKdn);
                fields[15] = Convert.ToString(record.FactKdn);
                fields[16] = Convert.ToString(record.RuralKdn);
                fields[18] = Convert.ToString(record.PlanPercent);
                fields[20] = Convert.ToString(record.Mortality);
                fields[22] = Convert.ToString(record.AverageStay);
                fields[24] = Convert.ToString(record.BedWork);
                fields[26] = Convert.ToString(record.BedTurnOver);
                fields[28] = Convert.ToString(record.RuralPercent);
                fill.Add(fields);
            }
            int height = 4;
            foreach (string[] arr in fill)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    worksheet.Cells[height, i + 1] = arr[i];
                }
                height++;
            }

            worksheet.Columns["A:AC"].Autofit();

            application.Visible = true;
            application.UserControl = true;
        }
    }
}
