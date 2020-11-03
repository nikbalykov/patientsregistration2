using PatientsRegistration.Domain.Enum;
using PatientsRegistration.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatientsRegistration.Service
{
    //Сервис для работы с Record
    public class RecordService
    {
        //Контекст
        public RecordContext RecordContext { get; set; }
        
        //Конструктор
        public RecordService(RecordContext recordContext)
        {
            this.RecordContext = recordContext;
        }

        //Метод, возвращающий лист ДТО
        public List<RecordDto> GetRecordDtoList(int month, int year)
        {
            List<Record> records = SortRecords(GetRecordsByDate(month, year));
            return records.Select(r => RecordMapper.ToRecordDto(r)).ToList();
        }

        //Метод, возвращающий лист ДТО, обогащенных рассчитываемыми показателями
        public List<RecordFullDto> GetRecordFullDtoList(int month, int year)
        {
            List<Record> records = SortRecords(GetRecordsByDate(month, year));
            return records.Select(r => RecordMapper.ToRecordFullDto(r)).ToList();
        }

        //Метод, возвращающий отсортированный лист Record по наименованию и иерархии
        private List<Record> SortRecords(List<Record> records)
        {
            List<Record> result = new List<Record>();
            for(int i = 0; i < records.Count; i++)
            {
                if(records.ElementAt<Record>(i).IsParent)
                {
                    result.Add(records.ElementAt<Record>(i));
                    records.Remove(records.ElementAt<Record>(i));
                    i--;
                }
            }
            result = result.OrderBy(r => r.Name).ToList();
            records = records.OrderBy(r => r.Name).Reverse<Record>().ToList();
            result.AddRange(records);
            for(int i = 0; i < result.Count; i++)
            {
                for(int j = 0; j < result.Count; j++)
                {
                    if(result.ElementAt<Record>(i).Id == Convert.ToInt32(result.ElementAt<Record>(j).ParentId))
                    {
                        result.Insert(i + 1, result.ElementAt<Record>(j));
                        result.RemoveAt(j + 1);
                    }
                }
            }
            return result;
        }

        //Метод, возвращающий массив наименований родительских экземпляров
        public object[] GetParentList(int month, int year)
        {
            List<string> records = RecordContext.Records.Where(r => r.Month == month
                && r.Year == year && r.IsParent).Select(r => r.Name).ToList();
            records.Sort();
            object[] recordsArray = new object[records.Count];
            for(int i = 0; i < records.Count; i++)
            {
                recordsArray[i] = records.ElementAt<string>(i);
            }
            return recordsArray;
        }

        //Метод, возвращающий лист Record по заданной дате
        private List<Record> GetRecordsByDate(int month, int year)
        {
            return RecordContext.Records.Where(r => r.Month == month
                && r.Year == year).ToList();
        }

        //Метод, возвращающий идентификатор Record по наименованию
        public int FindRecordByName(string name)
        {
            return RecordContext.Records.Where(r => r.Name.Equals(name)).Select(r => r.Id).First<int>();
        }
    }
}