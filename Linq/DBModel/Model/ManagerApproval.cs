using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class ManagerApproval
    {
        public ManagerApproval()
        {
            InverseParent = new HashSet<ManagerApproval>();
            ManagerApprovalInboxes = new HashSet<ManagerApprovalInbox>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long? SourceId { get; set; }
        public int ScheduleId { get; set; }
        public int? AdjVersion { get; set; }
        public string Status { get; set; }
        public int PersonnelId { get; set; }
        public string Guid { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SignOpinion { get; set; }
        public int? CreatePersonnelId { get; set; }
        public DateTime? SignTime { get; set; }

        public virtual ManagerApproval Parent { get; set; }
        public virtual ICollection<ManagerApproval> InverseParent { get; set; }
        public virtual ICollection<ManagerApprovalInbox> ManagerApprovalInboxes { get; set; }
    }
}
