using praktichesko_izpitvane_nomer134869.Data.Models;
using System;

namespace praktichesko_izpitvane_nomer134869
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new RentCarsContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
