using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class MaintenanceContract
    {
        public int Id { get; set; }
        public string ContractIdExt { get; set; }
        public string Name { get; set; }
        public string ContractDescription { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Remark { get; set; }
    }
}
