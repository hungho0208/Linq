using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class AdjustScheduleDetail
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int PersonId { get; set; }
        public DateTime? OldDate { get; set; }
        public DateTime? NewDate { get; set; }
        public int? OldShiftId { get; set; }
        public int? NewShiftId { get; set; }
        public string AdjustType { get; set; }
        public string AdjustReason { get; set; }
        public int? LeaveHours { get; set; }
        public int? DelegateUserId { get; set; }
        public string Guid { get; set; }
    }
}
