using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AvtosalonContext : DbContext
    {
        public AvtosalonContext()
        {
            Database.EnsureCreated();
        }

        public AvtosalonContext(DbContextOptions<AvtosalonContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Sale> Purchases { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }
    }
}
