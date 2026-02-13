using POS.Models;
using POS.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmInvoice : Form
    {
        private ERPDbContext _context = new ERPDbContext();
        public FrmInvoice()
        {
            InitializeComponent();
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadItems();
            GenerateInvoiceNumber();
        }
        private void LoadCustomers()
        {
            cmbCustomer.DataSource = _context.Customers.ToList();
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "Id";
        }
        private void LoadItems()
        {
            cmbItems.DataSource = _context.Items.ToList();
            cmbItems.DisplayMember = "ItemName";
            cmbItems.ValueMember = "Id";
        }
        private void GenerateInvoiceNumber()
        {
            txtInvoiceNumber.Text = "INV-" + DateTime.Now.Ticks.ToString().Substring(10);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbItems.SelectedItem == null)
                return;

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter valid quantity");
                return;
            }

            var selectedItem = (Item)cmbItems.SelectedItem;

            decimal price = selectedItem.Price;
            decimal lineTotal = price * quantity;

            dgvItems.Rows.Add(
                selectedItem.Id,
                selectedItem.ItemName,
                quantity,
                price,
                lineTotal
            );

            CalculateTotal();

        }
        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                total += Convert.ToDecimal(row.Cells["colLineTotal"].Value);
            }

            lblTotal.Text = "Total: " + total.ToString("0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem == null)
            {
                MessageBox.Show("Select customer");
                return;
            }

            if (dgvItems.Rows.Count == 0)
            {
                MessageBox.Show("Add at least one item");
                return;
            }

            var invoice = new Invoice
            {
                InvoiceNumber = txtInvoiceNumber.Text,
                InvoiceDate = dtInvoiceDate.Value,
                CustomerId = (int)cmbCustomer.SelectedValue,
                TotalAmount = decimal.Parse(lblTotal.Text.Replace("Total: ", ""))
            };

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                invoice.InvoiceDetails.Add(new InvoiceDetail
                {
                    ItemId = Convert.ToInt32(row.Cells["colItemId"].Value),
                    Quantity = Convert.ToInt32(row.Cells["colQuantity"].Value),
                    Price = Convert.ToDecimal(row.Cells["colPrice"].Value),
                    LineTotal = Convert.ToDecimal(row.Cells["colLineTotal"].Value)
                });
            }

            _context.Invoices.Add(invoice);
            _context.SaveChanges();

            MessageBox.Show("Invoice Saved Successfully");

            dgvItems.Rows.Clear();
            GenerateInvoiceNumber();
            CalculateTotal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Remove(dgvItems.CurrentRow);
            CalculateTotal();
        }
    }
}
