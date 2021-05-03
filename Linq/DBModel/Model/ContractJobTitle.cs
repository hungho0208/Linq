using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class ContractJobTitle
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string JobTitle { get; set; }
        public string Remark { get; set; }
    }
}
