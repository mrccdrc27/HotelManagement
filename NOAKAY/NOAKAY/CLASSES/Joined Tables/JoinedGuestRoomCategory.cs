using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAKAY.CLASSES.Joined_Tables
{
    [Keyless]
    public class GuestRoomCategoryDTO
    {
        public int GuestID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Suffix { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string? GuestStatus { get; set; }
        public int RoomID { get; set; }
        public int RoomNum { get; set; }
        public string CategoryName { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
