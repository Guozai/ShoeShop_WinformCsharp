using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Shop
{
    public partial class FormEdit : Form
    {
        private double money;
        private FormMain formMain;

        public FormEdit(FormMain formMain, double money)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.money = money;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            textBoxMoney.Text = money.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxMoney.Text, out money))
            {
                formMain.updateMyMoney(money);
                formMain.refreshTextBoxMoney(money);
            }
            else
                MessageBox.Show("Input must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
