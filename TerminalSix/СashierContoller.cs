using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalStore
{
   

    public class СashierContoller
    {
        ShoppingSession shoppingSession;
        List<ShoppingSession> shoppingSessionDay;
        СashierMap cassiraMap;


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





    }
}
