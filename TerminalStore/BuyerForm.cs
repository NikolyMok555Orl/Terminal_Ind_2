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
            buyerController.SetDiscount(ref comboBoxDiscount);
            comboBoxDiscount.SelectedIndex = -1;
            panelAtTheCheckout.Enabled = false;
            buyerController.LabelSumFinal = labelSumFinal;
            buyerController.TextBoxReceipt = textBoxReceipt;
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

        private void buttonToCassira_Click(object sender, EventArgs e)
        {
            if (buyerController.GoToCheckout())
            {
                panelAtTheCheckout.Enabled = true;
                //buttonGiveMoney.Enabled = false;
                buyerController.DataGridMonitor = dataGridViewPurchasesOnTape;
                panelAddPurchase.Enabled = false;
                dataGridViewPurchasesOnTape.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Касса занята. Пожалуйста подойти позже");
            }
           

        }

        private void buttonTakePurchases_Click(object sender, EventArgs e)
        {
            panelAddPurchase.Enabled = true;
            panelAtTheCheckout.Enabled = false;
            dataGridViewPurchases.Rows.Clear();
            dataGridViewPurchasesOnTape.Rows.Clear();
            textBoxReceipt.Text = "";
        }

        /// <summary>
        /// Дать денег
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGiveMoney_Click(object sender, EventArgs e)
        {
            if (textBoxMoney.TextLength > 0)
            {
                buyerController.Pay(Convert.ToInt32(textBoxMoney.Text));
            }
        }

        private void buttonDeleteLastBuyer_Click(object sender, EventArgs e)
        {
            buyerController.DeleteLastProduct();
        }

        private void buttonShowDiscount_Click(object sender, EventArgs e)
        {
            buyerController.ShowDiscountCard(Convert.ToInt32(comboBoxDiscount.SelectedValue));
        }
    }
}
