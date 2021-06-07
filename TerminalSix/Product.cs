using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalStore
{
    /// <summary>
    /// Товары. Продукты
    /// </summary>
    public class Product
    {
        public Product(string name, bool isWight)
        {
            Name = name;
            IsWight = isWight;
        }

        [Key]
        public int ProductId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public bool IsWight { get; set; }


        public List<DiscountCard> DiscountCards { get; set; }


        public List<Purchase> Purchases { get; set; }
    }
}
