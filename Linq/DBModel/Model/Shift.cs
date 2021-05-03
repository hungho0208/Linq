using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class Shift
    {
        public int Id { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan? BeginTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string CrossDay { get; set; }
        public string Remark { get; set; }
    }
}
