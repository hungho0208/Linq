using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class ManagerApprovalInbox
    {
        public long Id { get; set; }
        public long ManagerApprovalId { get; set; }
        public int PersonnelId { get; set; }
        public string IsApproval { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ManagerApproval ManagerApproval { get; set; }
    }
}
