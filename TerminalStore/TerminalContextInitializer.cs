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

            Product product1 = new Product("Яйца", false, 7);
            Product product2 = new Product("Хлеб", false, 23);
            Product product3 = new Product("Картошка", true, 50);
            Product product4 = new Product("Слиток золота", true, 136142);

            context.Product.Add(product1);
            context.Product.Add(product2);
            context.Product.Add(product3);
            context.Product.Add(product4);
            context.SaveChanges();
            СashierMap cashierMap = new СashierMap("Татьяна", "1", "Татьяна");
            context.СashierMap.Add(cashierMap);
            //context.SaveChanges();

            DiscountCard discountCardAll = new DiscountCard("На всё", true, 5);

            DiscountCard discountCardBread = new DiscountCard("Хлебная", false, 10);
            //product2.DiscountCards.Add(discountCardBread);
            discountCardBread.Products.Add(product2);
            context.Discount.Add(discountCardAll);
            context.Discount.Add(discountCardBread);
            
            context.SaveChanges();



           /* using (TerminalContext terminalContext = new TerminalContext())
            {
                terminalContext.Discount.Load();
                List<DiscountCard> discountCard = terminalContext.Discount.Include(p=>p.Products).ToList();
            }*/
            //base.Seed(context);
        }
    }
}
