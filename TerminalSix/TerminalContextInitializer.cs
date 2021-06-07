using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalStore
{
    class TerminalContextInitializer : DropCreateDatabaseAlways<TerminalContext>
    {
        protected override void Seed(TerminalContext context)
        {

            Product product1 = new Product("яйца", false);
            Product product2 = new Product("хлеб", true);

            context.Product.Add(product1);
            context.Product.Add(product2);
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}
