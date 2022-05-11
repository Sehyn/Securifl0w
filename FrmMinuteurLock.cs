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

namespace Securifl0w
{
    public partial class FrmMinuteurLock : Form
    {
        public FrmMinuteurLock()
        {
            InitializeComponent();
        }

        private void TxtCodeNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnDeverouiller_Click(object sender, EventArgs e)
        {

            if (TxtCodeNum.Text == Properties.Settings.Default.code)
            {
                Process.Start("explorer.exe");
                this.Hide();
                Form f1 = new FrmPanel();
                f1.Show();
            }
            else
            {

            }
        }

        private void FrmMinuteurLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            LblFermer.Visible = true;
            e.Cancel = true;

        }
    }
}
