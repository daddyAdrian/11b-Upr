using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mebeli.Data
{
    public class FurnitureContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public FurnitureContext() { }
        public FurnitureContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConfigurationString);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
