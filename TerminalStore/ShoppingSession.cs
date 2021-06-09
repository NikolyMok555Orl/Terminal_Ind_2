using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalStore
{
    /// <summary>
    /// Сессия покупки. Чек
    /// </summary>
    public class ShoppingSession
    {
        public ShoppingSession()
        {
            DateSessoin = DateTime.Now;
            Purchases = new List<Purchase>();
        }

        public ShoppingSession(СashierMap cassiraMap) : this()
        {
            СashierMap = cassiraMap;
        }


        public ShoppingSession(DiscountCard discountCard, List<Purchase> purchases, СashierMap cassiraMap)
        {
            DiscountCard = discountCard;
            Purchases = purchases;
            СashierMap = cassiraMap;
        }

        [Key]
        public int SessionId { get; set; }
        public DateTime DateSessoin { get; set; }
        

        

        [ForeignKey("DiscountCard")]
        public int? DiscountCardId { get; set; }
        public DiscountCard DiscountCard { get; set; }

        public List<Purchase> Purchases { get; set; }

        [ForeignKey("СashierMap")]
        public int СashierMapId { get; set; }
        public СashierMap СashierMap { get; set; }




        public static bool SendShoppingSessionDay(List<ShoppingSession> shoppingSession)
        {
            try
            {
                using (TerminalContext context = new TerminalContext())
                {
                    context.ShoppingSession.AddRange(shoppingSession);

                    context.SaveChanges();
                    return true;

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ошибка при отправки данных: "+ex);
                return false;
            } 

        }
    }

}
