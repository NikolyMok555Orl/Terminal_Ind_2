using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalStore
{
   

    public class CashierController
    {
        ShoppingSession shoppingSession;
        List<ShoppingSession> shoppingSessionDay;
        СashierMap cassiraMap;
        BuyerForm buyerForm;
        DiscountCard discountCard;
        int money;
        bool excessMoney;
        BuyerController buyerController;
        List<Product> products;
        Label tape, thisProduct;
        bool isService;



        /// <summary>
        /// Добавление покупки
        /// </summary>
        /// <param name="shoppingSession"></param>
        public delegate void HappenConsidered(ShoppingSession shoppingSession);
        event HappenConsidered happenConsidered;

        /// <summary>
        /// Итог
        /// </summary>
        /// <param name="shoppingSession"></param>
        public delegate void HappenEndSessiong(ShoppingSession shoppingSession, int sum);
        event HappenEndSessiong happenEnd;



        public CashierController(Label tape,Label thisProduct)
        {
            this.tape = tape;
            this.thisProduct = thisProduct;
            money = 0;
            excessMoney = false;
            isService = false;
        }


        public void SetStartMoney()
        {
            money = 5000;
        }

        public void SetСashierMap(ref ComboBox comboBoxСashierMap)
        {
            // List<Product> products =Product.GetAllProduct();
            // comboBoxAllProduct.Items.AddRange((object)products);
            using (TerminalContext terminalContext = new TerminalContext())
            {
                terminalContext.СashierMap.Load();
                comboBoxСashierMap.DataSource = terminalContext.СashierMap.Local;
                comboBoxСashierMap.ValueMember = "CassiraMapId";
                comboBoxСashierMap.DisplayMember = "Login";
            }

        }

        /// <summary>
        /// Вход кассира
        /// </summary>
        /// <param name="idCassiraMap"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool EntrerCassira(int idCassiraMap, String pass)
        {
            using (TerminalContext terminalContext = new TerminalContext())
            {

                cassiraMap = terminalContext.СashierMap.FirstOrDefault(p => p.CassiraMapId == idCassiraMap && p.Pass.Equals(pass));
                if (cassiraMap != null )
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Старт кассы
        /// </summary>
        /// <returns></returns>
        public bool CanStart()
        {
            if (money >= 5000) return true;
            return false;
        }


        public void StartCashbox()
        {
            buyerController = new BuyerController(this);
            shoppingSessionDay = new List<ShoppingSession>();
            buyerForm = new BuyerForm(buyerController);
            buyerForm.Show();
        }

        public bool StartSessionShoping(List<Product> products)
        {
            if (!isService)
            {
                this.products = products;
                tape.Text = products.First().ToString();
                shoppingSession = new ShoppingSession();
                MessageBox.Show("Подошёл покупатель");
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Считывание продукта
        /// </summary>
        /// <param name="dataGridProduct"></param>
        public void ReadProduct(DataGridView dataGridProduct)
        {
            if (products.Count > 0)
            {
                Product product = products.First();
                products.Remove(product);
                shoppingSession = new ShoppingSession(cassiraMap.CassiraMapId);
                Purchase purchase = new Purchase(product.ProductId, 0, shoppingSession.SessionId);


            }
            else
            {
                MessageBox.Show("Товаров на ленте закончилось");
            }

        }
             
    }
}
