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
        CashierController сashierContoller;
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
                сashierContoller = new CashierController();
                FormLogin formLogin = new FormLogin(сashierContoller);
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

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (сashierContoller.CanStart())
            {
                сashierContoller.StartCashbox();
                panelCassier.Enabled = true;
            }
        }

        private void buttonAdd5000_Click(object sender, EventArgs e)
        {
            сashierContoller.SetStartMoney();
            buttonStart.Enabled = true;
        }
    }
}
