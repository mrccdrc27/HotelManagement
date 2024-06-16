using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Room
    {
        public int RoomID { get; set; }
        public string? CategoryID { get; set; }
        public int Session { get; set; }
        
        public virtual ObservableCollection <Category>

    }
}
