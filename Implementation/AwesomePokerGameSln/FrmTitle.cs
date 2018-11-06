using AwesomePokerGameSln.Properties;
using System;
using System.Windows.Forms;

namespace AwesomePokerGameSln {
    public partial class FrmTitle : Form {
        // create the form
        public FrmTitle() {
            InitializeComponent();
            settingsPanel.Visible = false;
            changeThemePanel.Visible = false;
            Console.WriteLine("Amount of stars - " + Stars.Amount);
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
            Hide();
            FrmPlaygame frmPlaygame = new FrmPlaygame();
            frmPlaygame.ShowDialog();
            Close();
        }

        // view the settings page
        private void settingsButtonClick(object sender, EventArgs e)
        {
            // hide main menu buttons and show settings buttons
            mainMenuPanel.Visible = false;
            settingsPanel.Visible = true;
        }

        // toggle fullscreen
        private void button_fullscreen_Click(object sender, EventArgs e)
        {
            // fullscreen
            if (WindowState != FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            // window
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
        }

        // view change theme page
        private void button_change_theme_Click(object sender, EventArgs e)
        {
            // hide settings buttons and show change theme buttons
            settingsPanel.Visible = false;
            changeThemePanel.Visible = true;
        }

        // go back to main menu
        private void button_back_Click(object sender, EventArgs e)
        {
            // hide settings buttons and show menu buttons
            settingsPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        private void button_back_to_settings_Click(object sender, EventArgs e)
        {
            // hide change theme buttons and show menu buttons
            changeThemePanel.Visible = false;
            settingsPanel.Visible = true;
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
