using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class ScheduleDetail
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public DateTime ImportTime { get; set; }
        public int Version { get; set; }
        public int? ExcelSeqId { get; set; }
        public string Name { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public int? ShiftId { get; set; }
        public string ExcelJobTitle { get; set; }
        public string IsEdit { get; set; }
    }
}
