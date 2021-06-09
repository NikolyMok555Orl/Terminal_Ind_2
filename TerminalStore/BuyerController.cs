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
        DataGridView dataGridMonitor;
        Label labelSumFinal;
        TextBox textBoxReceipt;
        public DataGridView DataGridMonitor {set => dataGridMonitor = value; }
        public Label LabelSumFinal { set => labelSumFinal = value; }
        public TextBox TextBoxReceipt { set => textBoxReceipt = value; }

        /// <summary>
        /// Показ дисконтки
        /// </summary>
        /// <param name="discountCard"></param>
        public delegate void HappenShowDiscount(DiscountCard discountCard);
        event HappenShowDiscount showDiscount;


        /// <summary>
        /// Показ дисконтки
        /// </summary>
        /// <param name="discountCard"></param>
        public delegate void HappenDeleteLastProduct();
        event HappenDeleteLastProduct eventDelete;

        public BuyerController(CashierController cashierController)
        {
            this.cashierController = cashierController;
            productsInBasket = new List<Product>();
        }
        /// <summary>
        /// Добавление продукции
        /// </summary>
        /// <param name="comboBoxAllProduct"></param>
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
                //comboBoxAllProduct.DisplayMember =(terminalContext.Product.Find(Convert.ToInt32(comboBoxAllProduct.SelectedValue))).Name;
            }

        }


        public void SetDiscount(ref ComboBox comboBoxAllDiscount)
        {
            // List<Product> products =Product.GetAllProduct();
            // comboBoxAllProduct.Items.AddRange((object)products);
            using (TerminalContext terminalContext = new TerminalContext())
            {
                terminalContext.Discount.Load();
                comboBoxAllDiscount.DataSource = terminalContext.Discount.Local;
                comboBoxAllDiscount.ValueMember = "DiscountCardId";
                comboBoxAllDiscount.DisplayMember = "Name";
                //comboBoxAllProduct.DisplayMember =(terminalContext.Product.Find(Convert.ToInt32(comboBoxAllProduct.SelectedValue))).Name;
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

        /// <summary>
        /// Отправиться к кассе
        /// </summary>
        /// <returns></returns>
        public bool GoToCheckout()
        {
            if (productsInBasket is null || productsInBasket.Count == 0) {

                MessageBox.Show("Положите что-то в корзинку");
                return false; }
            if (cashierController.StartSessionShoping(productsInBasket, NewWriteProduct, ShowFinalSum, ShowReceipt)) return true;
            else return false;

        }


        /// <summary>
        /// Новое считование или ввод количества
        /// </summary>
        /// <param name="shoppingSession"></param>
        public void NewWriteProduct(ShoppingSession shoppingSession)
        {
            if (shoppingSession != null)
            {
                SetDateGrid.SetReceipt(dataGridMonitor, shoppingSession);


            }
        }

       

        /// <summary>
        /// Показ итоговой суммы
        /// </summary>
        public void ShowFinalSum(ShoppingSession shoppingSession, double sum)
        {
            labelSumFinal.Text = "Сумма к оплате: " + sum + " рублей";
        }

        /// <summary>
        /// Показ чека
        /// </summary>
        /// <param name="receipt"></param>
        public void ShowReceipt(string receipt)
        {
            textBoxReceipt.Text = receipt;
        }



        public void Pay(int money)
        {
            if (money <= 0) MessageBox.Show("Хорошая попытка. Долгом не расплачиваеся");

            if (cashierController.Pay(money))
            {
                MessageBox.Show("Подожди сейчас дадим чек и сдачу");
            }
            else
            {
                MessageBox.Show("Мало денег");
            }


        }


        /// <summary>
        /// Удаление последнего 
        /// </summary>
        public void DeleteLastProduct()
        {
            cashierController.DeleteLastProduct();
        }



        public void ShowDiscountCard(int idDiscount)
        {
            if (idDiscount > 0)
            {
                using (TerminalContext terminalContext = new TerminalContext())
                {
                    DiscountCard discountCard = terminalContext.Discount.FirstOrDefault(d => d.DiscountCardId == idDiscount);
                    if(discountCard != null)
                    {
                        cashierController.PutDiscointCard(discountCard);
                    }
                    else
                    {
                        MessageBox.Show("Месья, что за фальшивку вы кладёте?");
                    }
                }
            }
            else
            {

                MessageBox.Show("Сударь, где ваша карта?");
            }


        }
    }
}
