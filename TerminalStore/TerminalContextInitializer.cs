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

            Product product1 = new Product("яйца", false, 7);
            Product product2 = new Product("хлеб", false, 23);
            Product product3 = new Product("картошка", true, 50);

            context.Product.Add(product1);
            context.Product.Add(product2);
            context.Product.Add(product3);
            СashierMap cashierMap = new СashierMap("Татьяна", "1", "Татьяна");
            context.СashierMap.Add(cashierMap);

            DiscountCard discountCardAll = new DiscountCard("На всё", true, 5);
            DiscountCard discountCardBread = new DiscountCard("Хлебная", false, 10, new List<Product>() { product2 });
            context.Discount.Add(discountCardAll);
            context.Discount.Add(discountCardBread);
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}
