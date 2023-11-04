using Inventory.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructore.DataBase
{
    public class InventoryDB : DbContext
    {
        public DbSet<Order> Order { get; set; }

        public InventoryDB(DbContextOptions<InventoryDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
                .HasKey(k => k.CustomerName);
        }
    }
}
