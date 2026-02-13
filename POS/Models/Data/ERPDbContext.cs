using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Models.Data
{
    public class ERPDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=AHMED\\SQLEXPRESS;Database=SimpleERP_DB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, CustomerName = "Ahmed" },
                new Customer { Id = 2, CustomerName = "Mohamed" }
            );

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, ItemName = "Keyboard", Price = 200 },
                new Item { Id = 2, ItemName = "Mouse", Price = 100 },
                new Item { Id = 3, ItemName = "Monitor", Price = 3000 }
            );
        }

    }
}
