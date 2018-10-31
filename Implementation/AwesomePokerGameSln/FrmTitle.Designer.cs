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
        this.button_new_game = new System.Windows.Forms.Button();
        this.button_rulebook = new System.Windows.Forms.Button();
        this.button_quit = new System.Windows.Forms.Button();
        this.label_title2 = new System.Windows.Forms.Label();
        this.picture_rulebook = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.picture_rulebook)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label_title.AutoSize = true;
        this.label_title.BackColor = System.Drawing.Color.Transparent;
        this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label_title.ForeColor = System.Drawing.Color.Yellow;
        this.label_title.Location = new System.Drawing.Point(25, -74);
        this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label_title.Name = "label1";
        this.label_title.Size = new System.Drawing.Size(821, 189);
        this.label_title.TabIndex = 0;
        this.label_title.Text = "Awesome";
        // 
        // btnNewGame
        // 
        this.button_new_game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.button_new_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.button_new_game.Location = new System.Drawing.Point(76, 577);
        this.button_new_game.Margin = new System.Windows.Forms.Padding(4);
        this.button_new_game.Name = "btnNewGame";
        this.button_new_game.Size = new System.Drawing.Size(281, 107);
        this.button_new_game.TabIndex = 1;
        this.button_new_game.Text = "New Game";
        this.button_new_game.UseVisualStyleBackColor = false;
        this.button_new_game.Click += new System.EventHandler(this.newGameButtonClick);
        // 
        // btnViewRuleBook
        // 
        this.button_rulebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.button_rulebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.button_rulebook.Location = new System.Drawing.Point(499, 577);
        this.button_rulebook.Margin = new System.Windows.Forms.Padding(4);
        this.button_rulebook.Name = "btnViewRuleBook";
        this.button_rulebook.Size = new System.Drawing.Size(317, 107);
        this.button_rulebook.TabIndex = 2;
        this.button_rulebook.Text = "View Rule Book";
        this.button_rulebook.UseVisualStyleBackColor = false;
        this.button_rulebook.Click += new System.EventHandler(this.rulebookButtonClick);
        // 
        // btnQuit
        // 
        this.button_quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        this.button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.button_quit.Location = new System.Drawing.Point(951, 577);
        this.button_quit.Margin = new System.Windows.Forms.Padding(4);
        this.button_quit.Name = "btnQuit";
        this.button_quit.Size = new System.Drawing.Size(281, 107);
        this.button_quit.TabIndex = 3;
        this.button_quit.Text = "Quit Game";
        this.button_quit.UseVisualStyleBackColor = false;
        this.button_quit.Click += new System.EventHandler(this.quitButtonClick);
        // 
        // label2
        // 
        this.label_title2.AutoSize = true;
        this.label_title2.BackColor = System.Drawing.Color.Transparent;
        this.label_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label_title2.ForeColor = System.Drawing.Color.Yellow;
        this.label_title2.Location = new System.Drawing.Point(41, 206);
        this.label_title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label_title2.Name = "label2";
        this.label_title2.Size = new System.Drawing.Size(539, 189);
        this.label_title2.TabIndex = 4;
        this.label_title2.Text = "Game";
        // 
        // picRulebook
        // 
        this.picture_rulebook.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.rule_book;
        this.picture_rulebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.picture_rulebook.Location = new System.Drawing.Point(305, 140);
        this.picture_rulebook.Margin = new System.Windows.Forms.Padding(4);
        this.picture_rulebook.Name = "picRulebook";
        this.picture_rulebook.Size = new System.Drawing.Size(673, 383);
        this.picture_rulebook.TabIndex = 5;
        this.picture_rulebook.TabStop = false;
        this.picture_rulebook.Visible = false;
        // 
        // FrmTitle
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.ClientSize = new System.Drawing.Size(1267, 689);
        this.Controls.Add(this.picture_rulebook);
        this.Controls.Add(this.label_title2);
        this.Controls.Add(this.button_quit);
        this.Controls.Add(this.button_rulebook);
        this.Controls.Add(this.button_new_game);
        this.Controls.Add(this.label_title);
        this.Margin = new System.Windows.Forms.Padding(4);
        this.Name = "FrmTitle";
        this.Text = "Awesome Poker Game";
        ((System.ComponentModel.ISupportInitialize)(this.picture_rulebook)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
        
    }

    #endregion
    
    private System.Windows.Forms.Label label_title;
    private System.Windows.Forms.Button button_new_game;
    private System.Windows.Forms.Button button_rulebook;
    private System.Windows.Forms.Button button_quit;
    private System.Windows.Forms.Label label_title2;
    private System.Windows.Forms.PictureBox picture_rulebook;
    }
}

