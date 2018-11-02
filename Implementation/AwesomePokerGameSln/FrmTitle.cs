using AwesomePokerGameSln.Properties;
using System;
using System.Windows.Forms;

namespace AwesomePokerGameSln {
    public partial class FrmTitle : Form {
        // create the form
        public FrmTitle() {
            InitializeComponent();
        }
    
        // exit button
        private void quitButtonClick(object sender, EventArgs e) {
            Application.Exit();
        }

        // view the rulebook button
        private void rulebookButtonClick(object sender, EventArgs e) {
            // if the rulebook isn't open, then open the rule book and change the button text
            if (button_rulebook.Text.StartsWith("View", true, null)) {
                picture_rulebook.Visible = true;
                button_rulebook.Text = "Close Rule Book";
            }
            // else, close the rulebook and then change the button text back
            else {
                picture_rulebook.Visible = false;
                button_rulebook.Text = "View Rule Book";
            }
        }
    
        // start the game button
        private void newGameButtonClick(object sender, EventArgs e) {
            // start the actual game form and hide this title form
            FrmPlaygame frmPlaygame = new FrmPlaygame();
            frmPlaygame.Show();
            Hide();
        }

        private void settingsButtonClick(object sender, EventArgs e)
        {
            // open settings page
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            Hide();
        }
    }
}
