using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalStore
{
    /// <summary>
    /// Скидки
    /// </summary>
    public class DiscountCard
    {
        public DiscountCard()
        {
        }

        public DiscountCard(string name, bool isAllProduct, int size)
        {
            Name = name;
            IsAllProduct = isAllProduct;
            Size = size;
            ShoppingSessions = new List<ShoppingSession>();
            Product = new List<Product>();
        }

        [Key]
        public int DiscountCardId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public bool IsAllProduct { get; set; }
        
        public int Size { get; set; }

        public List<ShoppingSession> ShoppingSessions { get; set; }

        public List<Product> Product { get; set; }
    }
}
