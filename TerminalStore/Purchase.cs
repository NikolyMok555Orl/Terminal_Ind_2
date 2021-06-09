using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalStore
{
    /// <summary>
    /// Покупка. Один товар в чеке
    /// </summary>
    public class Purchase
    {
        public Purchase()
        {
        }

        public Purchase( Product product, int sizeAndCount, ShoppingSession shoppingSession)
        {
            Product = product;
            ProductId = product.ProductId;
            SizeAndCount = sizeAndCount;
            ShoppingSession = shoppingSession;
            //ShoppingSession = shoppingSession;
        }

        [Key]
        public int PurchaseId { get; set; }

       // public int ShopingSessinId { get; set; }
   
        public int ProductId { get; set; }
        public Product Product { get; set; }

        /// <summary>
        /// Вес в граммах/количества
        /// </summary>
        public int SizeAndCount { get; set; }

        [ForeignKey("ShoppingSession")]
        public int ShoppingSessionId { get; set; }
        public ShoppingSession ShoppingSession { get; set; }



        
    }
}
