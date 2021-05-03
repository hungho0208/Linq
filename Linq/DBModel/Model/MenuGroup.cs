using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class MenuGroup
    {
        public MenuGroup()
        {
            MenuItems = new HashSet<MenuItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsTemplate { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
