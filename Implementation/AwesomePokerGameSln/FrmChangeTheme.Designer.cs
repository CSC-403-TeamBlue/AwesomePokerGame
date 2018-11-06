namespace AwesomePokerGameSln
{
    partial class FrmChangeTheme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deck_halloween = new System.Windows.Forms.Button();
            this.deck_ninja = new System.Windows.Forms.Button();
            this.deck_waluigi = new System.Windows.Forms.Button();
            this.deck_george = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.cardBackPanel = new System.Windows.Forms.TableLayoutPanel();
            this.deck_canada = new System.Windows.Forms.Button();
            this.cardBackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deck_halloween
            // 
            this.deck_halloween.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.halloween_back;
            this.deck_halloween.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_halloween.Location = new System.Drawing.Point(3, 3);
            this.deck_halloween.Name = "deck_halloween";
            this.deck_halloween.Size = new System.Drawing.Size(189, 252);
            this.deck_halloween.TabIndex = 0;
            this.deck_halloween.UseVisualStyleBackColor = true;
            this.deck_halloween.Click += new System.EventHandler(this.deck_halloween_Click);
            // 
            // deck_ninja
            // 
            this.deck_ninja.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.ninja_back;
            this.deck_ninja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_ninja.Location = new System.Drawing.Point(255, 3);
            this.deck_ninja.Name = "deck_ninja";
            this.deck_ninja.Size = new System.Drawing.Size(189, 252);
            this.deck_ninja.TabIndex = 1;
            this.deck_ninja.UseVisualStyleBackColor = true;
            this.deck_ninja.Click += new System.EventHandler(this.deck_ninja_Click);
            // 
            // deck_waluigi
            // 
            this.deck_waluigi.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.waluigi_back;
            this.deck_waluigi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_waluigi.Location = new System.Drawing.Point(507, 3);
            this.deck_waluigi.Name = "deck_waluigi";
            this.deck_waluigi.Size = new System.Drawing.Size(189, 252);
            this.deck_waluigi.TabIndex = 2;
            this.deck_waluigi.UseVisualStyleBackColor = true;
            this.deck_waluigi.Click += new System.EventHandler(this.deck_waluigi_Click);
            // 
            // deck_george
            // 
            this.deck_george.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.washington_back;
            this.deck_george.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_george.Location = new System.Drawing.Point(759, 3);
            this.deck_george.Name = "deck_george";
            this.deck_george.Size = new System.Drawing.Size(189, 252);
            this.deck_george.TabIndex = 3;
            this.deck_george.UseVisualStyleBackColor = true;
            this.deck_george.Click += new System.EventHandler(this.deck_george_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(483, 535);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(328, 123);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // cardBackPanel
            // 
            this.cardBackPanel.AutoSize = true;
            this.cardBackPanel.BackColor = System.Drawing.Color.Transparent;
            this.cardBackPanel.ColumnCount = 9;
            this.cardBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.cardBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cardBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.cardBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cardBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.cardBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cardBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.cardBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cardBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.cardBackPanel.Controls.Add(this.deck_halloween, 0, 0);
            this.cardBackPanel.Controls.Add(this.deck_canada, 8, 0);
            this.cardBackPanel.Controls.Add(this.deck_george, 6, 0);
            this.cardBackPanel.Controls.Add(this.deck_waluigi, 4, 0);
            this.cardBackPanel.Controls.Add(this.deck_ninja, 2, 0);
            this.cardBackPanel.Location = new System.Drawing.Point(40, 269);
            this.cardBackPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardBackPanel.Name = "cardBackPanel";
            this.cardBackPanel.RowCount = 1;
            this.cardBackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.cardBackPanel.Size = new System.Drawing.Size(1260, 258);
            this.cardBackPanel.TabIndex = 6;
            // 
            // deck_canada
            // 
            this.deck_canada.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.canada_back;
            this.deck_canada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_canada.Location = new System.Drawing.Point(1011, 3);
            this.deck_canada.Name = "deck_canada";
            this.deck_canada.Size = new System.Drawing.Size(189, 252);
            this.deck_canada.TabIndex = 4;
            this.deck_canada.UseVisualStyleBackColor = true;
            this.deck_canada.Click += new System.EventHandler(this.deck_canada_Click);
            // 
            // FrmChangeTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.cardBackPanel);
            this.Controls.Add(this.button_back);
            this.Name = "FrmChangeTheme";
            this.Text = "FrmChangeTheme";
            this.cardBackPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deck_halloween;
        private System.Windows.Forms.Button deck_ninja;
        private System.Windows.Forms.Button deck_waluigi;
        private System.Windows.Forms.Button deck_george;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TableLayoutPanel cardBackPanel;
        private System.Windows.Forms.Button deck_canada;
    }
}