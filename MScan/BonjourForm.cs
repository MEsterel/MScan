using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MScan
{
    public partial class BonjourForm : Form
    {
        private bool ValidExit = false;

        public BonjourForm()
        {
            InitializeComponent();
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedDPI = Properties.Settings.Default.normalDPI;
            Finish();
        }


        private void mailBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedDPI = Properties.Settings.Default.mailDPI;
            Finish();
        }

        private void preciseBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedDPI = Properties.Settings.Default.preciseDPI;
            Finish();
        }
        private void Finish()
        {
            Properties.Settings.Default.Save();
            ValidExit = true;
            Close();
        }

        private void BonjourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ValidExit)
            {
                Application.Exit();
            }
        }
    }
}
