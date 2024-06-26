using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NOAKAY.CLASSES
{
    public class BookingRecord
    {
        [Key]
        public int bookingRecord { get; set; }
        [ForeignKey("guestID")]
        public int? guestID { get; set; }
        public virtual GuestModel guest { get; set; } = null!;
    }
}
