using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    }
}
