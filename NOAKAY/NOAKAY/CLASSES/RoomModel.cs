using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Collections.ObjectModel;

namespace NOAKAY.CLASSES
{
    public class RoomModel
    {
        [Key]
        public int RoomID { get; set; }

        public int? RoomStatus { get; set; }
        [NotMapped] // Not mapped to database
        public string RoomStatusDisplay
        {
            get
            {
                if (RoomStatus.HasValue)
                {
                    return RoomStatus == 0 ? "Occupied" :
                           RoomStatus == 1 ? "Available" :
                           "Unknown"; // Handle any other values if needed
                }
                return "Unknown"; // Default value if GuestStatus is null
            }
        }

        public int RoomNum { get; set; }
        public int CategoryId { get; set; } // Foreign key referencing CategoryModel

        public virtual CategoryModel Category { get; set; } // Navigation property

        public virtual ObservableCollection<GuestModel> Guests { get; set; } = new ObservableCollection<GuestModel>();
    }
}