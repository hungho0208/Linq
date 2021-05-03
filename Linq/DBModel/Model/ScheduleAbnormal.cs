using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class ScheduleAbnormal
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int Version { get; set; }
        public string CompareDescription { get; set; }
        public string AbnormalReason { get; set; }
    }
}
