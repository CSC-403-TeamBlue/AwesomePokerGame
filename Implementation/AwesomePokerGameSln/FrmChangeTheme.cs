using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomePokerGameSln
{
    public partial class FrmChangeTheme : Form
    {
        public FrmChangeTheme()
        {
            InitializeComponent();
        }

        // go back to settings
        private void button_back_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            Hide();
        }

        private void deck_halloween_Click(object sender, EventArgs e)
        {

        }

        private void deck_ninja_Click(object sender, EventArgs e)
        {

        }

        private void deck_waluigi_Click(object sender, EventArgs e)
        {

        }

        private void deck_george_Click(object sender, EventArgs e)
        {

        }

        private void deck_canada_Click(object sender, EventArgs e)
        {

        }
    }
}
