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
    /// Сессия покупки. Чек
    /// </summary>
    public class ShoppingSession
    {
        public ShoppingSession()
        {
        }

        public ShoppingSession(DiscountCard discountCard, List<Purchase> purchases, СashierMap cassiraMap)
        {
            DiscountCard = discountCard;
            Purchases = purchases;
            CassiraMap = cassiraMap;
        }

        [Key]
        public int SessionId { get; set; }
        public DateTime DateSessoin { get; set; }
        

        

        [ForeignKey("DiscountCard")]
        public int? DiscountCardId { get; set; }
        public DiscountCard DiscountCard { get; set; }

        public List<Purchase> Purchases { get; set; }

        [ForeignKey("CassiraMap")]
        public int CassiraMapId { get; set; }
        public СashierMap CassiraMap { get; set; }

    }
}
