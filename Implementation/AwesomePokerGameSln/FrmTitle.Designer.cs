namespace AwesomePokerGameSln {
    partial class FrmTitle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
        components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.label_title = new System.Windows.Forms.Label();
            this.label_title2 = new System.Windows.Forms.Label();
            this.picture_rulebook = new System.Windows.Forms.PictureBox();
            this.mainMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_new_game = new System.Windows.Forms.Button();
            this.button_rulebook = new System.Windows.Forms.Button();
            this.button_setting = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_fullscreen = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_change_theme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.star_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rulebook)).BeginInit();
            this.mainMenuPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Yellow;
            this.label_title.Location = new System.Drawing.Point(-1, -54);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(588, 168);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Awesome";
            // 
            // label_title2
            // 
            this.label_title2.AutoSize = true;
            this.label_title2.BackColor = System.Drawing.Color.Transparent;
            this.label_title2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title2.ForeColor = System.Drawing.Color.Yellow;
            this.label_title2.Location = new System.Drawing.Point(73, 174);
            this.label_title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title2.Name = "label_title2";
            this.label_title2.Size = new System.Drawing.Size(379, 168);
            this.label_title2.TabIndex = 4;
            this.label_title2.Text = "Game";
            // 
            // picture_rulebook
            // 
            this.picture_rulebook.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.rule_book;
            this.picture_rulebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuPanel.SetColumnSpan(this.picture_rulebook, 2);
            this.picture_rulebook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picture_rulebook.Location = new System.Drawing.Point(289, 4);
            this.picture_rulebook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture_rulebook.Name = "picture_rulebook";
            this.picture_rulebook.Size = new System.Drawing.Size(562, 78);
            this.picture_rulebook.TabIndex = 5;
            this.picture_rulebook.TabStop = false;
            this.picture_rulebook.Visible = false;
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.AutoSize = true;
            this.mainMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuPanel.ColumnCount = 4;
            this.mainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainMenuPanel.Controls.Add(this.button_new_game, 0, 1);
            this.mainMenuPanel.Controls.Add(this.button_rulebook, 1, 1);
            this.mainMenuPanel.Controls.Add(this.button_setting, 2, 1);
            this.mainMenuPanel.Controls.Add(this.button_quit, 3, 1);
            this.mainMenuPanel.Controls.Add(this.picture_rulebook, 1, 0);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 357);
            this.mainMenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.RowCount = 2;
            this.mainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.mainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.mainMenuPanel.Size = new System.Drawing.Size(1141, 205);
            this.mainMenuPanel.TabIndex = 8;
            // 
            // button_new_game
            // 
            this.button_new_game.AutoSize = true;
            this.button_new_game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_new_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_new_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new_game.Location = new System.Drawing.Point(4, 90);
            this.button_new_game.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_new_game.Name = "button_new_game";
            this.button_new_game.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_new_game.Size = new System.Drawing.Size(277, 111);
            this.button_new_game.TabIndex = 1;
            this.button_new_game.Text = "New Game";
            this.button_new_game.UseVisualStyleBackColor = false;
            this.button_new_game.Click += new System.EventHandler(this.newGameButtonClick);
            // 
            // button_rulebook
            // 
            this.button_rulebook.AutoSize = true;
            this.button_rulebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_rulebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_rulebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rulebook.Location = new System.Drawing.Point(289, 90);
            this.button_rulebook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_rulebook.Name = "button_rulebook";
            this.button_rulebook.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_rulebook.Size = new System.Drawing.Size(277, 111);
            this.button_rulebook.TabIndex = 2;
            this.button_rulebook.Text = "View Rule Book";
            this.button_rulebook.UseVisualStyleBackColor = false;
            this.button_rulebook.Click += new System.EventHandler(this.rulebookButtonClick);
            // 
            // button_setting
            // 
            this.button_setting.AutoSize = true;
            this.button_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_setting.Location = new System.Drawing.Point(573, 88);
            this.button_setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_setting.Name = "button_setting";
            this.button_setting.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_setting.Size = new System.Drawing.Size(279, 115);
            this.button_setting.TabIndex = 6;
            this.button_setting.Text = "Settings";
            this.button_setting.UseVisualStyleBackColor = false;
            this.button_setting.Click += new System.EventHandler(this.settingsButtonClick);
            // 
            // button_quit
            // 
            this.button_quit.AutoSize = true;
            this.button_quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_quit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quit.Location = new System.Drawing.Point(859, 90);
            this.button_quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_quit.Name = "button_quit";
            this.button_quit.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_quit.Size = new System.Drawing.Size(278, 111);
            this.button_quit.TabIndex = 3;
            this.button_quit.Text = "Quit Game";
            this.button_quit.UseVisualStyleBackColor = false;
            this.button_quit.Click += new System.EventHandler(this.quitButtonClick);
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoSize = true;
            this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsPanel.ColumnCount = 3;
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.settingsPanel.Controls.Add(this.button_fullscreen, 0, 0);
            this.settingsPanel.Controls.Add(this.button_back, 2, 0);
            this.settingsPanel.Controls.Add(this.button_change_theme, 1, 0);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsPanel.Location = new System.Drawing.Point(0, 237);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.RowCount = 1;
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.settingsPanel.Size = new System.Drawing.Size(1141, 120);
            this.settingsPanel.TabIndex = 9;
            // 
            // button_fullscreen
            // 
            this.button_fullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_fullscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_fullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fullscreen.Location = new System.Drawing.Point(3, 2);
            this.button_fullscreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_fullscreen.Name = "button_fullscreen";
            this.button_fullscreen.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_fullscreen.Size = new System.Drawing.Size(374, 116);
            this.button_fullscreen.TabIndex = 0;
            this.button_fullscreen.Text = "Toggle Fullscreen";
            this.button_fullscreen.UseVisualStyleBackColor = false;
            this.button_fullscreen.Click += new System.EventHandler(this.button_fullscreen_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(763, 2);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_back.Size = new System.Drawing.Size(375, 116);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_change_theme
            // 
            this.button_change_theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_change_theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_change_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_theme.Location = new System.Drawing.Point(383, 2);
            this.button_change_theme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_change_theme.Name = "button_change_theme";
            this.button_change_theme.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_change_theme.Size = new System.Drawing.Size(374, 116);
            this.button_change_theme.TabIndex = 1;
            this.button_change_theme.Text = "Change Theme";
            this.button_change_theme.UseVisualStyleBackColor = false;
            this.button_change_theme.Click += new System.EventHandler(this.button_change_theme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.star;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(859, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // star_count
            // 
            this.star_count.AutoSize = true;
            this.star_count.BackColor = System.Drawing.Color.Transparent;
            this.star_count.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star_count.ForeColor = System.Drawing.Color.Yellow;
            this.star_count.Location = new System.Drawing.Point(941, 57);
            this.star_count.Name = "star_count";
            this.star_count.Size = new System.Drawing.Size(69, 29);
            this.star_count.TabIndex = 11;
            this.star_count.Text = "label1";
            this.star_count.Click += new System.EventHandler(this.star_count_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(941, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "S T A R S";
            // 
            // FrmTitle
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.star_count);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.label_title2);
            this.Controls.Add(this.label_title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTitle";
            this.Text = "Awesome Poker Game";
            ((System.ComponentModel.ISupportInitialize)(this.picture_rulebook)).EndInit();
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    
    private System.Windows.Forms.Label label_title;
    private System.Windows.Forms.Button button_settings;
    private System.Windows.Forms.Label label_title2;
    private System.Windows.Forms.PictureBox picture_rulebook;
        private System.Windows.Forms.TableLayoutPanel mainMenuPanel;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_rulebook;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Button button_new_game;
        private System.Windows.Forms.TableLayoutPanel settingsPanel;
        private System.Windows.Forms.Button button_fullscreen;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_change_theme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label star_count;
        private System.Windows.Forms.Label label1;
    }
}

