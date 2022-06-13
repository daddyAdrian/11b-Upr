using Mebeli.Data;
using System;

namespace Mebeli
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new FurnitureContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
