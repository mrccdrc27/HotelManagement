using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAKAY.CLASSES.Joined_Tables
{
    public class RecordBooking
    {
        [Key]
        public int RecordBookingID { get; set; }
        public int BookStatus { get; set; }

        [ForeignKey("GuestID")]
        public int? GuestID { get; set; }
        public virtual GuestModel guest { get; set; } = null!;


    }
}
