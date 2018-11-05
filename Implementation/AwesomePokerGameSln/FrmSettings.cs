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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        // open change themes menu
        private void button_change_theme_Click(object sender, EventArgs e)
        {
            Hide();
            FrmChangeTheme frmChangeTheme = new FrmChangeTheme();
            frmChangeTheme.ShowDialog();
            Close();
        }

        // go back to main menu
        private void button_back_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTitle frmTitle = new FrmTitle();
            frmTitle.ShowDialog();
            Close();
        }

        // toggle fullscreen
        private void button_fullscreen_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
