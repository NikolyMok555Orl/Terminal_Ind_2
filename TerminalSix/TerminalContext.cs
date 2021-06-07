using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalStore
{
    public class TerminalContext : DbContext
    {
        public TerminalContext()
            : base("DbConnection")
        { }



        static TerminalContext()
        {
            Database.SetInitializer<TerminalContext>(new TerminalContextInitializer());
        }


        public DbSet<CassiraMap> CassiraMap { get; set; }
        public DbSet<DiscountCard> Discount { get; set; }
        public DbSet<Product> Product { get; set; }
       // public DbSet<ProductAndDiscount> ProductAndDiscount { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<ShoppingSession> ShoppingSession { get; set; }

    }
}
