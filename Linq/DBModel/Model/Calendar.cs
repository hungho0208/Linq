using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class Calendar
    {
        public DateTime ThisDate { get; set; }
        public int Dw { get; set; }
        public string IsHoliday { get; set; }
        public string Remark { get; set; }
    }
}
