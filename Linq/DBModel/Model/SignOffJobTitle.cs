using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class SignOffJobTitle
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string NeedSignOff { get; set; }
        public int? JobLevel { get; set; }
    }
}
