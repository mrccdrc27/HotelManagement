using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace NOAKAY.CLASSES
{
    public class BillingModel
    {
        [Key]
        public int InvoiceID { get; set; }
        public DateTime? InvoiceDdate { get; set; }
        public int GuestID { get; set; }
        [ForeignKey("GuestID")]
        public virtual GuestModel Guests { get; set; } = null!;

    }
}
