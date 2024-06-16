using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        
        public int Rate { get; set; }

        public virtual Room Room { get; set; } = null!;


    }
}
