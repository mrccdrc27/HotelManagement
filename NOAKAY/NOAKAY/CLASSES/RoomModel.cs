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

        // RoomStatus derived property
        [NotMapped] // Not mapped to database
        public int RoomStatus
        {
            get
            {
                if (Guests != null || Guests.Any())
                {
                   // MessageBox.Show("YESSSSS");
                    // Check if any guest is checked in
                    bool isOccupied = Guests.Any(g => g.GuestStatus == 0);

                    if (isOccupied)
                        return 0; // Example: 1 might represent "Occupied"
                    else
                        return 1; // Example: 2 might represent "Available"
                }
                else
                {
                    MessageBox.Show("YESSSSS");
                    return 0; // Default to "Available" if no guests are associated

                }
            }
        }
        public string RoomStatusDisplay
        {
            get
            {
                switch (RoomStatus)
                {
                    case 0:
                        return "Occupied";
                    case 1:
                        return "Available";
                    default:
                        return "Unknown"; // Handle any other values if needed
                }
            }
        }

        public int RoomNum { get; set; }
        public int CategoryId { get; set; } // Foreign key referencing CategoryModel

        public virtual CategoryModel Category { get; set; } // Navigation property

        public virtual ObservableCollection<GuestModel> Guests { get; set; } = new ObservableCollection<GuestModel>();
    }
}
