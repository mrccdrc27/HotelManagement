using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//code change

namespace HMS
{
    public class Guest
    {
        [Key]
        public int GuestID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public int RoomID { get; set; }
        public virtual Room Room { get; set; } = null!;
        //public virtual ObservableCollectionListSource<Room> Rooms { get; set; } = new();


    }
}
