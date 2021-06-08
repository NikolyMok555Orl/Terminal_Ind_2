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

        public Product()
        {
        }

        [Key]
        public int ProductId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public bool IsWight { get; set; }


        public List<DiscountCard> DiscountCards { get; set; }

        /// <summary>
        /// Получить список всех товаров
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetAllProduct()
        {
            using (TerminalContext db = new TerminalContext())
            {
                var product = db.Product.ToList();
                return product;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product)) return false;

            if ((obj as Product).ProductId == ProductId) return true;
            else return false;
        }

        public List<Purchase> Purchases { get; set; }
    }
}
