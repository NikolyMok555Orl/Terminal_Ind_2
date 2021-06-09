using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalStore
{
    public class BuyerController
    {
        List<Product> productsInBasket;
        CashierController cashierController;

        public BuyerController(CashierController cashierController)
        {
            this.cashierController = cashierController;
            productsInBasket = new List<Product>();
        }

        public void SetProduct(ref ComboBox comboBoxAllProduct)
        {
            // List<Product> products =Product.GetAllProduct();
            // comboBoxAllProduct.Items.AddRange((object)products);
            using (TerminalContext terminalContext = new TerminalContext())
            {
                terminalContext.Product.Load();
                comboBoxAllProduct.DataSource = terminalContext.Product.Local;
                comboBoxAllProduct.ValueMember = "ProductId";
                comboBoxAllProduct.DisplayMember = "Name";
            }

        }


        /// <summary>
        /// Положить в корзинку
        /// </summary>
        public void PutInTheBasket(int idProduct, DataGridView dataGridBasket)
        {
            if (productsInBasket is null) productsInBasket = new List<Product>();
            using (TerminalContext terminalContext = new TerminalContext())
            {
                //terminalContext.Product.Load();
                Product productAdd = terminalContext.Product.FirstOrDefault(p=>p.ProductId==idProduct);
                if(productAdd != null && !productsInBasket.Contains(productAdd))
                {
                    productsInBasket.Add(productAdd);
                    dataGridBasket.ColumnCount = 1;
                    dataGridBasket.Columns[0].HeaderText = "Товар";
                    dataGridBasket.Rows.Add(productAdd.ToString());

                }
            }
        }

        /// <summary>
        /// Удаляет из корзинки продукт
        /// </summary>
        /// <param name="dataGridBasket"></param>
        public void DeleteInTheBasket(DataGridView dataGridBasket)
        {
            
            using (TerminalContext terminalContext = new TerminalContext())
            {
                //terminalContext.Product.Load();
                
                if (productsInBasket!=null && productsInBasket.Count>0)
                {
                    productsInBasket.RemoveAt(productsInBasket.Count-1);

                    //dataGridBasket.Rows.RemoveAt(dataGridBasket.RowCount-1);
                    dataGridBasket.RowCount = dataGridBasket.RowCount - 1;
                }
            }
        }

    }
}
