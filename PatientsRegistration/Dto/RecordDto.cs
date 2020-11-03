namespace PatientsRegistration.Domain.Enum
{
    //Дто сущности Record
    public class RecordDto
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
    }
}
