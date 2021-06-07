using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalStore
{
    /// <summary>
    /// Скидки на продукты
    /// </summary>
    public class ProductAndDiscount
    {
        [Key]
        public int ProductId { get; set; }
        [Key]
        public int DiscountCardId { get; set; }
    }
}
