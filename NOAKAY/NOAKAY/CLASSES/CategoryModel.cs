using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAKAY.CLASSES
{
    public class CategoryModel
    {
        [Key]
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }

        public virtual ObservableCollectionListSource<RoomModel> Rooms { get; set; } = new();
    }
}
