using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalStore
{
    public class SetDateGrid
    {





        public static void SetReceipt(DataGridView dataGridMonitor, ShoppingSession shoppingSession)
        {
            dataGridMonitor.ColumnCount = 3;
            dataGridMonitor.Columns[0].HeaderText = "Товар";
            dataGridMonitor.Columns[1].HeaderText = "Вес/количиество";
            dataGridMonitor.Columns[2].HeaderText = "Стоимость";
            dataGridMonitor.Rows.Clear();
            using (TerminalContext context = new TerminalContext())
            {
                foreach (var purchase in shoppingSession.Purchases)
                {
                    string[] purchaseStr = new string[dataGridMonitor.ColumnCount];

                    Product product = context.Product.Find(purchase.ProductId);
                    purchaseStr[0] = product.Name;
                    purchaseStr[1] = string.Format("{0} {1}", purchase.SizeAndCount, product.IsWightStr);

                    double sizeDiscount = 1;
                    if (shoppingSession.DiscountCard != null)
                    {
                        sizeDiscount = shoppingSession.DiscountCard.GetSizeDiscountOnProduct(product);

                    }

                    purchaseStr[2] = Convert.ToString((purchase.SizeAndCount * product.Price)* (1-sizeDiscount));

                    dataGridMonitor.Rows.Add(purchaseStr);

                }
            }




        }
    }
}
