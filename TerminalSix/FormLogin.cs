using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalStore
{
    public partial class FormLogin : Form
    {
        СashierContoller сashierContoller;
        public FormLogin(СashierContoller сashierContoller)
        {
            //сashierContoller = new СashierContoller();

            InitializeComponent();
            this.сashierContoller = сashierContoller;
            сashierContoller.SetСashierMap(ref comboBoxLogin);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxPass.TextLength > 0)
            {
                if(сashierContoller.EntrerCassira(Convert.ToInt32(comboBoxLogin.SelectedValue), textBoxPass.Text)) {

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }


            }
        }
    }
}
