using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalSix
{
    public class TerminalContext : DbContext
    {
        public TerminalContext()
            : base("DbConnection")
        { }


        public DbSet<CassiraMap> CassiraMap { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductAndDiscount> ProductAndDiscount { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<ShoppingSession> ShoppingSession { get; set; }

    }
}
