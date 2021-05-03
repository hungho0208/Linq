using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class ScheduleMaster
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public int ContractSysId { get; set; }
        public DateTime ScheduleMonth { get; set; }
        public int? FormalVersion { get; set; }
        public int? AdjVersion { get; set; }
        public string Status { get; set; }
    }
}
