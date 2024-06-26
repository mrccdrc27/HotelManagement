using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace NOAKAY.CLASSES
{
      public class GuestModel
    {
        [Key]
        public int GuestID { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Suffix { get; set; }
        public string? Email { get; set; }
        public string? Contact { get; set; }
        public int? GuestStatus { get; set; }
        // Additional read-only property for display purposes
        [NotMapped] // Not mapped to database
        public string GuestStatusDisplay
        {
            get
            {
                if (GuestStatus.HasValue)
                {
                    return GuestStatus == 0 ? "CheckIn" :
                           GuestStatus == 1 ? "CheckOut" :
                           "Unknown"; // Handle any other values if needed
                }
                return "Unknown"; // Default value if GuestStatus is null
            }
        }   
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }

        public int RoomID { get; set; }

        [ForeignKey("RoomID")]
        public virtual RoomModel Rooms { get; set; } = null!;
        public virtual ObservableCollection<BookingRecord> booking { get; set; } = new ObservableCollection<BookingRecord>();
    }
}
