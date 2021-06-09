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
            //DiscountCardProducts = new List<DiscountCardProduct>();
            Products = new List<Product>();
        }

        public DiscountCard(string name, bool isAllProduct, int size)
        {
            Name = name;
            IsAllProduct = isAllProduct;
            Size = size;
            ShoppingSessions = new List<ShoppingSession>();
            //DiscountCardProducts = new List<DiscountCardProduct>();
            Products = new List<Product>();
        }

        //List<DiscountCardProduct> products
        public DiscountCard(string name, bool isAllProduct, int size, List<Product> products) 
        {
            Name = name;
            IsAllProduct = isAllProduct;
            Size = size;
            //DiscountCardProducts = products;
            Products = products;

        }


        [Key]
        public int DiscountCardId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public bool IsAllProduct { get; set; }
        
        public int Size { get; set; }

        public List<ShoppingSession> ShoppingSessions { get; set; }


        //public List<DiscountCardProduct> DiscountCardProducts { get; set; }
        public List<Product> Products { get; set; }



        public double GetSizeDiscountOnProduct(Product product)
        {
            double sizeDiscount = 0;
            if (this.IsAllProduct)
            {
                return this.Size / 100.0;

            }
            else
            {

                /*using (TerminalContext terminalContext=new TerminalContext())
                {
                   



                }*/
                if (Products.Contains(product)) return this.Size / 100.0;
            }

            return sizeDiscount;
        }
    }
}
