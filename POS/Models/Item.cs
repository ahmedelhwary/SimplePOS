using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }

    }
}
