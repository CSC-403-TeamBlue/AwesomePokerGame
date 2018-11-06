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
            Hide();
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
            Close();
        }

        private void deck_halloween_Click(object sender, EventArgs e)
        {
            CardBack.Kind = CardBack.BackType.HALLOWEEN;
            MessageBox.Show("Theme changed to Halloween", "Theme Change", MessageBoxButtons.OK);
        }

        private void deck_ninja_Click(object sender, EventArgs e)
        {
            CardBack.Kind = CardBack.BackType.NINJA;
            MessageBox.Show("Theme changed to Ninja", "Theme Change", MessageBoxButtons.OK);
        }

        private void deck_waluigi_Click(object sender, EventArgs e)
        {
            CardBack.Kind = CardBack.BackType.WALUIGI;
            MessageBox.Show("Theme changed to Waluigi", "Theme Change", MessageBoxButtons.OK);
        }

        private void deck_george_Click(object sender, EventArgs e)
        {
            CardBack.Kind = CardBack.BackType.GEORGE;
            MessageBox.Show("Theme changed to George Washington", "Theme Change", MessageBoxButtons.OK);
        }

        private void deck_canada_Click(object sender, EventArgs e)
        {
            CardBack.Kind = CardBack.BackType.CANADA;
            MessageBox.Show("Theme changed to Canada", "Theme Change", MessageBoxButtons.OK);
        }
    }
}
