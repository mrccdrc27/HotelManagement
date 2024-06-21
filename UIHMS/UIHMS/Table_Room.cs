using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UIHMS
{


    public class Room_Table
    {
        [Key]
        public int RoomID { get; set; }
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category_Table Category_Tables { get; set; } = null!;
        public virtual ObservableCollectionListSource<Guest_Table> Guest_Tables { get; set; } = new();

    }

}
