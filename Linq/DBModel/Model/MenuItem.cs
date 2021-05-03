using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class MenuItem
    {
        public int Id { get; set; }
        public bool SubMenu { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int OrderId { get; set; }
        public int Level { get; set; }
        public bool Enable { get; set; }
        public Guid Guid { get; set; }
        public int MenuGroupId { get; set; }

        public virtual MenuGroup MenuGroup { get; set; }
    }
}
