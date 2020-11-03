using PatientsRegistration.Domain.Enum;

namespace PatientsRegistration.Mapper
{
    //Класс преобразования для сущности Record
    public class RecordMapper
    {
        //Метод, преобразующий экземпляр Record в экземпляр RecordFullDto
        public static RecordFullDto ToRecordFullDto(Record record)
        {
            RecordFullDto recordFullDto = new RecordFullDto();
            recordFullDto.Id = record.Id;
            recordFullDto.IsParent = record.IsParent;
            recordFullDto.ParentId = record.ParentId;
            recordFullDto.Year = record.Year;
            recordFullDto.Month = record.Month;
            recordFullDto.Name = record.Name;
            if(record.DepartmentGroup == DepartmentGroup.Surgery)
            {
                recordFullDto.DepartmentGroup = "Хирургия";
            } 
            else if (record.DepartmentGroup == DepartmentGroup.Therapy)
            {
                recordFullDto.DepartmentGroup = "Терапия";
            }
            else if (record.DepartmentGroup == DepartmentGroup.DayHospital)
            {
                recordFullDto.DepartmentGroup = "Дневной стационар";
            }
            else
            {
                recordFullDto.DepartmentGroup = "Реанимация";
            }
            recordFullDto.BedCount = record.BedCount;
            recordFullDto.Consisted = record.Consisted;
            recordFullDto.Received = record.Received;
            recordFullDto.Rural = record.Rural;
            recordFullDto.RelocatedFrom = record.RelocatedFrom;
            recordFullDto.RelocatedTo = record.RelocatedTo;
            recordFullDto.Discharged = record.Discharged;
            recordFullDto.Died = record.Died;
            recordFullDto.Consist = record.Consist;
            recordFullDto.PlanKdn = record.PlanKdn;
            recordFullDto.FactKdn = record.FactKdn;
            recordFullDto.RuralKdn = record.RuralKdn;
            return recordFullDto;
        }

        //Метод, преобразующий экземпляр Record в экземпляр RecordDto
        public static RecordDto ToRecordDto(Record record)
        {
            RecordDto recordDto = new RecordDto();
            recordDto.Id = record.Id;
            recordDto.IsParent = record.IsParent;
            recordDto.ParentId = record.ParentId;
            recordDto.Year = record.Year;
            recordDto.Month = record.Month;
            recordDto.Name = record.Name;
            if (record.DepartmentGroup == DepartmentGroup.Surgery)
            {
                recordDto.DepartmentGroup = "Хирургия";
            }
            else if (record.DepartmentGroup == DepartmentGroup.Therapy)
            {
                recordDto.DepartmentGroup = "Терапия";
            }
            else if (record.DepartmentGroup == DepartmentGroup.DayHospital)
            {
                recordDto.DepartmentGroup = "Дневной стационар";
            }
            else
            {
                recordDto.DepartmentGroup = "Реанимация";
            }
            recordDto.BedCount = record.BedCount;
            recordDto.Consisted = record.Consisted;
            recordDto.Received = record.Received;
            recordDto.Rural = record.Rural;
            recordDto.RelocatedFrom = record.RelocatedFrom;
            recordDto.RelocatedTo = record.RelocatedTo;
            recordDto.Discharged = record.Discharged;
            recordDto.Died = record.Died;
            recordDto.Consist = record.Consist;
            recordDto.PlanKdn = record.PlanKdn;
            recordDto.FactKdn = record.FactKdn;
            recordDto.RuralKdn = record.RuralKdn;
            return recordDto;
        }
    }
}