using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class SignOffOrgn
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int? MgrId { get; set; }
        public int? Bpmlevel { get; set; }
    }
}
