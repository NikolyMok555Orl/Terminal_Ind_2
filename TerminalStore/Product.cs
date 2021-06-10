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
    /// Товары. Продукты
    /// </summary>
    public class Product
    {
        public Product(string name, bool isWight, int price)
        {
            Name = name;
            IsWight = isWight;
            if (price > 0) Price = price;
            // DiscountCardProducts = new List<DiscountCardProduct>();
            DiscountCards = new List<DiscountCard>();
        }

        public Product()
        {
            // DiscountCardProducts = new List<DiscountCardProduct>();
            DiscountCards = new List<DiscountCard>();
        }

        [Key]
        public int ProductId { get; set; }
        [MaxLength(20)][Required]
        public string Name { get; set; }
        [Required]
        public bool IsWight { get; set; }
        /// <summary>
        /// Цена за 1 штуку, или за 1 кг
        /// </summary>
        [Required]
        public int Price { get; set; }



        //public virtual List<DiscountCardProduct> DiscountCardProducts { get; set; }
        public List<DiscountCard> DiscountCards{ get; set; }
        [NotMapped]
        public string IsWightStr
        {
            get
            {
                return IsWight ? "г" : "шт";
            }
        }

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
            return string.Format("{0} {1} руб за {2}" , Name, Price, (IsWight?"кг":"шт"));
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product)) return false;

            if ((obj as Product).ProductId == ProductId) return true;
            else return false;
        }

        public List<Purchase> Purchases { get; set; }


        public double PriceOfOne() {
            return (Price / (IsWight ? 1000.0 : 1));
        }
    }
}
