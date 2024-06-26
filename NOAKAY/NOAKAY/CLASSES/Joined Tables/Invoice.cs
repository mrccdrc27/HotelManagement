using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAKAY.CLASSES.Joined_Tables
{
    public class Invoice
    {
        public int guestID { get; set; }
        public string? fullName { get; set; }
        public int? roomName { get; set; }
        public DateTime? checkIn { get; set; }
        public DateTime? checkOut { get; set; }
        public int? price { get; set; }
        public string? status { get; set; } // nilagay ko lang

    }
}
