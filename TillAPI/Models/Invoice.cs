using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TillAPI.Models
{
   public  class Invoice
    {
       public int Id { get; set; }
       public double Amount { get;set;}

       public int ChequeNumber { get; set; }

       public DateTime Date { get; set; }
       public double GST { get; set; }

       public string InvoiceNumber { get; set; }

       public string Paid { get; set; }

       public string PaymentType { get; set; }

       public string SupplierName { get; set; }
       public DateTime TimeCreated { get; set; }

       public virtual Employee FromUser { get; set; }
    }
}
