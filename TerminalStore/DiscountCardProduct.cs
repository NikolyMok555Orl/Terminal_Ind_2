using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalStore
{
    public class DiscountCardProduct
    {
        public DiscountCardProduct()
        {
        }

        public DiscountCardProduct(Product product, DiscountCard discountCard)
        {
            Product = product;
            DiscountCard = discountCard;
        }
        [ForeignKey("Product")][Key]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("DiscountCard")]
        [Key]

        public int DiscountCardId { get; set; }
        public DiscountCard DiscountCard { get; set; }
    }
}
