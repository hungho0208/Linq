using System;
using System.Collections.Generic;

#nullable disable

namespace DBModel.Model
{
    public partial class SignOffPersonnel
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string LoginAccount { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public int? MenuGroupId { get; set; }
        public DateTime? PasswordUpdateTime { get; set; }
    }
}
