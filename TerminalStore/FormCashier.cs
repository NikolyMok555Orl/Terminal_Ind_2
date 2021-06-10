using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalStore
{
    public partial class FormCashier : Form
    {
        CashierController cashierController;
        public FormCashier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                TerminalContext context = new TerminalContext();
                panelCassier.Enabled = false;
                buttonEndDay.Enabled = false;
                buttonStart.Enabled = false;
               
                // Запустить инициализацию базы данных в этой точке
                context.Database.Initialize(false);
                cashierController = new CashierController(labelFirstPurchase, labelThisProduct, labelSum, dataGridViewPurchase, labelDiscountCard);
                FormLogin formLogin = new FormLogin(cashierController);
                formLogin.ShowDialog();

                if (formLogin.DialogResult == DialogResult.OK)
                {



                }
                else
                {
                    Close();
                }

            }
            catch (Exception ex)
            {
                // Если при создании БД возникла ошибка, 
                // отобразим ее в окне отладчика
                MessageBox.Show(""+ex);
                // Если при создании БД возникла ошибка, 
                // отобразим ее в окне отладчика
                Debug.WriteLine("Инициализация не выполнена. Ошибка: ");
                Debug.WriteLine(ex.Message);
                Close();

            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            cashierController.ReadProduct();
            buttonSayFinalSum.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (cashierController.CanStart())
            {
                cashierController.StartCashbox();
                panelCassier.Enabled = true;
                buttonTotal.Enabled = false;
                buttonSayFinalSum.Enabled = false;
            }
        }

        private void buttonAdd5000_Click(object sender, EventArgs e)
        {
            cashierController.SetStartMoney();
            buttonStart.Enabled = true;
        }

        private void buttonWriteCountAndWight_Click(object sender, EventArgs e)
        {
            cashierController.SetCountWight(Convert.ToInt32(textBoxCountAndWight.Text), dataGridViewPurchase);
        }

        private void buttonSayFinalSum_Click(object sender, EventArgs e)
        {
            if(cashierController.SayFinalSum()) buttonTotal.Enabled = true;
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            if (cashierController.PurchasePaid())
            {
                cashierController.GiveCheckAndChange();
                dataGridViewPurchase.Rows.Clear();
                buttonEndDay.Enabled = true;
                labelSum.Text = "";
                labelThisProduct.Text = "";
                if (cashierController.ExcessMoney){ 
                    MessageBox.Show("Сдайте деньги");
                    panelCassier.Enabled = false;
                    }
            }
        }

        private void buttonHandOverMoney_Click(object sender, EventArgs e)
        {
            cashierController.HandOverMoney();
            cashierController.SetStartMoney();
            panelCassier.Enabled = true;
        }

        private void buttonEndDay_Click(object sender, EventArgs e)
        {
            if (cashierController.EndTheDay())
            {
                panelCassier.Enabled = false;

            }
        }

        private void buttonDeleteLast_Click(object sender, EventArgs e)
        {
            cashierController.DeleteLastProduct();
        }

        private void buttonWriteDiscount_Click(object sender, EventArgs e)
        {
            cashierController.TakeDiscointCard();
        }
    }
}
