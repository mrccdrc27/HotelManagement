using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public int CategoryID { get; set; }
        public virtual Category categories { get; set; } = null!; //foreign key
        public virtual ObservableCollectionListSource<Guest> Guests { get; set; } = new();

        //public virtual ObservableCollectionListSource<Category> Categories { get; set; } = new();
        //public virtual Guest Guest { get; set; } = null!; //foreign key

    }
}
