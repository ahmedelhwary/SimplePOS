using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

        public List<Invoice> Invoices { get; set; }
    }
}
