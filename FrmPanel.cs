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
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void FrmPanel_Load(object sender, EventArgs e)
        {
            GunaAnimate.Start();
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

        private void BtnMinuteur_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.code = TxtCodeNum.Text;
            Form f1 = new FrmMinuteurLock();
            //f1.Show();
            this.Hide();
            if (ComboboxMinuteur.Text == "TEST")
            {
                Timer_Minuteur.Interval = 10000;
                Timer_Minuteur.Start();
            }
            if (ComboboxMinuteur.Text == "1 minute")
            {
                Timer_Minuteur.Interval = 60000;
                Timer_Minuteur.Start();
            }
        }

        private void Timer_Minuteur_Tick(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("explorer"))
            {
                process.Kill();
            }
            Form f2 = new FrmMinuteurLock();
            f2.Show();
            Timer_Minuteur.Stop();
        }
    }
}
