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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_quit = new System.Windows.Forms.Button();
            this.button_rulebook = new System.Windows.Forms.Button();
            this.button_setting = new System.Windows.Forms.Button();
            this.button_new_game = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rulebook)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Yellow;
            this.label_title.Location = new System.Drawing.Point(-2, -18);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(708, 163);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Awesome";
            // 
            // label_title2
            // 
            this.label_title2.AutoSize = true;
            this.label_title2.BackColor = System.Drawing.Color.Transparent;
            this.label_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title2.ForeColor = System.Drawing.Color.Yellow;
            this.label_title2.Location = new System.Drawing.Point(83, 218);
            this.label_title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title2.Name = "label_title2";
            this.label_title2.Size = new System.Drawing.Size(465, 163);
            this.label_title2.TabIndex = 4;
            this.label_title2.Text = "Game";
            // 
            // picture_rulebook
            // 
            this.picture_rulebook.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.rule_book;
            this.picture_rulebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.picture_rulebook, 2);
            this.picture_rulebook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picture_rulebook.Location = new System.Drawing.Point(360, 5);
            this.picture_rulebook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture_rulebook.Name = "picture_rulebook";
            this.picture_rulebook.Size = new System.Drawing.Size(704, 479);
            this.picture_rulebook.TabIndex = 5;
            this.picture_rulebook.TabStop = false;
            this.picture_rulebook.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button_new_game, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_rulebook, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_setting, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_quit, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.picture_rulebook, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 222);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1425, 639);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // button_quit
            // 
            this.button_quit.AutoSize = true;
            this.button_quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_quit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quit.Location = new System.Drawing.Point(1072, 494);
            this.button_quit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(349, 140);
            this.button_quit.TabIndex = 3;
            this.button_quit.Text = "Quit Game";
            this.button_quit.UseVisualStyleBackColor = false;
            this.button_quit.Click += new System.EventHandler(this.quitButtonClick);
            // 
            // button_rulebook
            // 
            this.button_rulebook.AutoSize = true;
            this.button_rulebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_rulebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_rulebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rulebook.Location = new System.Drawing.Point(360, 494);
            this.button_rulebook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_rulebook.Name = "button_rulebook";
            this.button_rulebook.Size = new System.Drawing.Size(348, 140);
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
            this.button_setting.Location = new System.Drawing.Point(715, 492);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(350, 144);
            this.button_setting.TabIndex = 6;
            this.button_setting.Text = "Settings";
            this.button_setting.UseVisualStyleBackColor = false;
            this.button_setting.Click += new System.EventHandler(this.settingsButtonClick);
            // 
            // button_new_game
            // 
            this.button_new_game.AutoSize = true;
            this.button_new_game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_new_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_new_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new_game.Location = new System.Drawing.Point(4, 494);
            this.button_new_game.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_new_game.Name = "button_new_game";
            this.button_new_game.Size = new System.Drawing.Size(348, 140);
            this.button_new_game.TabIndex = 1;
            this.button_new_game.Text = "New Game";
            this.button_new_game.UseVisualStyleBackColor = false;
            this.button_new_game.Click += new System.EventHandler(this.newGameButtonClick);
            // 
            // FrmTitle
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1425, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_title2);
            this.Controls.Add(this.label_title);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTitle";
            this.Text = "Awesome Poker Game";
            ((System.ComponentModel.ISupportInitialize)(this.picture_rulebook)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    
    private System.Windows.Forms.Label label_title;
    private System.Windows.Forms.Button button_settings;
    private System.Windows.Forms.Label label_title2;
    private System.Windows.Forms.PictureBox picture_rulebook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_rulebook;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Button button_new_game;
    }
}

