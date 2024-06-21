using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UIHMS
{

    public class Guest_Table
    {
        [Key]
        public int GuestID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public int RoomID { get; set; }

        [ForeignKey("RoomID")]
        public virtual Room_Table Room_Table { get; set; } = null!;

    }


}
