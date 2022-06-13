using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public LibraryContext()
        {
            Database.EnsureCreated();
        }
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Integrated Security=true;Database=LibraryDb");
        }
    }
}
