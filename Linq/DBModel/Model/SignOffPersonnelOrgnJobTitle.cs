using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class SignOffPersonnelOrgnJobTitle
    {
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        public int OrgnId { get; set; }
        public int JobTitleId { get; set; }
    }
}
