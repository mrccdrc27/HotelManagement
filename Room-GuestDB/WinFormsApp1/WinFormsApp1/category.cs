using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string? category_name { get; set; }
        public virtual ObservableCollectionListSource<Room> Rooms { get; set; } = new();
    }
}
