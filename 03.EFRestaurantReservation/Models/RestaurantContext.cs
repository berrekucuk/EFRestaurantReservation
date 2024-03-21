using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EFRestaurantReservation.Models
{
    public class RestaurantContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-2K18C6FK\SQLEXPRESS01; Database=RestaurantDb; Trusted_Connection=True; TrustServerCertificate=True");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Resevation> Resevations { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
