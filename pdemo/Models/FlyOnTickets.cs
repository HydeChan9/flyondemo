using System;
using System.ComponentModel.DataAnnotations;

namespace pdemo.Models
{
    public class FlyOnTickets
    {
            [Key]
            public string BookingNumber { get; set; }
            public int Point { get; set; }
            public int TotalPrice { get; set; }
            public string PassportNumber { get; set; }
            public int MemberID { get; set; }
            public string FlightID { get; set; }

            [DataType(DataType.DateTime)]
            public DateTime TakeoffTime { get; set; }
        
    }
}

