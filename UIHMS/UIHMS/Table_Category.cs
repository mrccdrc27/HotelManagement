using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace UIHMS
{

    public class Category_Table
    {
        [Key]
        public int CategoryID { get; set; }
        public string? category_name { get; set; }
        public virtual ObservableCollectionListSource<Room_Table> Room_Tables { get; set; } = new();
    }

}
