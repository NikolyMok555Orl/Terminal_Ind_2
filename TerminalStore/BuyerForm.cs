using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalStore
{
    public partial class BuyerForm : Form
    {
        //TerminalStore.TerminalContext terminalContext;
        BuyerController buyerController;
        public BuyerForm(BuyerController buyerController)
        {
            InitializeComponent();
            this.buyerController=buyerController;
            
            buyerController.SetProduct(ref comboBoxProduct);

        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            buyerController.PutInTheBasket(Convert.ToInt32(comboBoxProduct.SelectedValue), dataGridViewPurchases );
        }

        private void buttonDeleteLast_Click(object sender, EventArgs e)
        {
            buyerController.DeleteInTheBasket(dataGridViewPurchases);
        }
    }
}
