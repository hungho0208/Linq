using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class Uv刷卡即時資訊
    {
        public string 契約名稱 { get; set; }
        public string 時段 { get; set; }
        public int 應到人數 { get; set; }
        public int 已到人數 { get; set; }
        public int? 未到人數 { get; set; }
        public int ContractId { get; set; }
    }
}
