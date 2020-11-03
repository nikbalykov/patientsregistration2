using System;

namespace PatientsRegistration
{
    //Дто сущности Record, содержащее все показатели + рассчитываемые показатели
    public class RecordFullDto
    {
        //Идентификатор
        public int Id { get; set; }
        //Флаг "является ли родительским элементом для других записей"
        public bool IsParent { get; set; }
        //Идентификатор родительской записи (при наличии)
        public string ParentId { get; set; }
        //Год
        public int Year { get; set; }
        //Месяц
        public int Month { get; set; }
        //Наименование
        public string Name { get; set; }
        //Группа отделений
        public string DepartmentGroup { get; set; }
        //Количество коек
        public double BedCount { get; set; }
        //Состояло
        public double Consisted { get; set; }
        //Поступило всего
        public double Received { get; set; }
        //В т.ч. сельских
        public double Rural { get; set; }
        //Переведено из другого
        public double RelocatedFrom { get; set; }
        //Переведено в другое
        public double RelocatedTo { get; set; }
        //Выписано
        public double Discharged { get; set; }
        //Умерло
        public double Died { get; set; }
        //Состоит
        public double Consist { get; set; }
        //План/кдн
        public double PlanKdn { get; set; }
        //Факт/кдн
        public double FactKdn { get; set; }
        //Кдн/сельских
        public double RuralKdn { get; set; }

        //% выполнения плана
        public double PlanPercent
        {
            get
            {
                if (PlanKdn == 0)
                    return 0;
                return Math.Round(FactKdn / PlanKdn * 100, 1);
            }
        }

        //Летальность
        public double Mortality
        {
            get
            {
                if ((Died + Discharged) == 0 | (Died + RelocatedTo) == 0)
                    return 0;
                if (DepartmentGroup == "Дневной стационар")
                {
                    return Math.Round(Died / (Died + RelocatedTo), 1);
                }
                else
                {
                    return Math.Round(Died / (Died + Discharged), 1);
                }
            }
        }

        //Среднее пребывание
        public double AverageStay
        {
            get
            {
                if ((Died + Discharged) == 0 | (Died + RelocatedTo) == 0)
                    return 0;
                if (DepartmentGroup == "Дневной стационар")
                {
                    return Math.Round(FactKdn / (Died + RelocatedTo), 1);
                }
                else
                {
                    return Math.Round(FactKdn / (Died + Discharged), 1);
                }
            }
        }

        //Работа койки
        public double BedWork
        {
            get
            {
                if (BedCount == 0)
                    return 0;
                return Math.Round(FactKdn / BedCount, 1);
            }
        }

        //Оборот койки
        public double BedTurnOver
        {
            get
            {
                if (BedCount == 0)
                    return 0;
                if (DepartmentGroup == "Дневной стационар")
                {
                    return Math.Round((Died + RelocatedTo) / BedCount, 1);
                }
                else
                {
                    return Math.Round((Died + Discharged) / BedCount, 1);
                }
            }
        }

        //% сельских жителей
        public double RuralPercent
        {
            get
            {
                if (Received == 0)
                    return 0;
                return Math.Round(Rural / Received * 100, 1);
            }
        }
    }
}
