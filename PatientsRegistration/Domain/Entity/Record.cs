namespace PatientsRegistration
{
    //Сущность записи
    public class Record
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
        public DepartmentGroup DepartmentGroup { get; set; }
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

        //Пустой конструктор
        public Record() { }

        //Конструктор для заполнения шаблона
        public Record(bool isParent, string parentId, int year, int month, string name, DepartmentGroup departmentGroup)
        {
            this.IsParent = isParent;
            this.ParentId = parentId;
            this.Year = year;
            this.Month = month;
            this.Name = name;
            this.DepartmentGroup = departmentGroup;
            this.BedCount = 0;
            this.Consisted = 0;
            this.Received = 0;
            this.Rural = 0;
            this.RelocatedFrom = 0;
            this.RelocatedTo = 0;
            this.Discharged = 0;
            this.Died = 0;
            this.Consist = 0;
            this.PlanKdn = 0;
            this.FactKdn = 0;
            this.RuralKdn = 0;
        }
    }
}
