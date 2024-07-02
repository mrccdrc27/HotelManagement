using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAKAY.CLASSES
{
    public class RoomGuestModel
    {
        public int RoomId { get; set; }
        public int GuestID { get; set;}
        public string? Status {get; set; }

        public DateTime? CheckIn { get; set; }

        public DateTime? CheckOut { get; set; }
    }
}
