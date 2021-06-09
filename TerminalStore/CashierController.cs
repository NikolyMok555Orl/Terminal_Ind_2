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
        int money;
        bool excessMoney;
        BuyerController buyerController;

        public CashierController()
        {
            money = 0;
            excessMoney = false;
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

    }
}
