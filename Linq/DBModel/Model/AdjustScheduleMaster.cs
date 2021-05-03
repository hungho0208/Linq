using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class AdjustScheduleMaster
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int Version { get; set; }
    }
}
