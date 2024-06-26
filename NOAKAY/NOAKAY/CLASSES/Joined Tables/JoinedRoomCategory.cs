using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAKAY.CLASSES.Joined_Tables
{
    // RoomCategoryDTO.cs
    [Keyless]
    public class RoomCategoryDTO
    {
        public int RoomId { get; set; }
        public string RoomStatus { get; set; }
        public string RoomNum { get; set; }
        public string CategoryName { get; set; }
    }

}
