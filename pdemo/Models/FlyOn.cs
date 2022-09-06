using System;
using System.ComponentModel.DataAnnotations;

namespace pdemo.Models
{
    public class FlyOn
    {
        [Key]
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public int TotalPoint { get; set; }
    }
}

