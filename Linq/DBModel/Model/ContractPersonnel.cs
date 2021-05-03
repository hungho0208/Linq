using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class ContractPersonnel
    {
        public int Id { get; set; }
        public int? ContractJobTitleId { get; set; }
        public string Name { get; set; }
        public string IdentityNum { get; set; }
        public string PunchCardNo { get; set; }
        public string ActiveStatus { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserId { get; set; }
    }
}
