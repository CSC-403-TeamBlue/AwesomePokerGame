﻿namespace AwesomePokerGameSln
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deck_canada = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deck_halloween
            // 
            this.deck_halloween.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.halloween_back;
            this.deck_halloween.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_halloween.Location = new System.Drawing.Point(2, 2);
            this.deck_halloween.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deck_halloween.Name = "deck_halloween";
            this.deck_halloween.Size = new System.Drawing.Size(126, 164);
            this.deck_halloween.TabIndex = 0;
            this.deck_halloween.UseVisualStyleBackColor = true;
            this.deck_halloween.Click += new System.EventHandler(this.deck_halloween_Click);
            // 
            // deck_ninja
            // 
            this.deck_ninja.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.ninja_back;
            this.deck_ninja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_ninja.Location = new System.Drawing.Point(170, 2);
            this.deck_ninja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deck_ninja.Name = "deck_ninja";
            this.deck_ninja.Size = new System.Drawing.Size(126, 164);
            this.deck_ninja.TabIndex = 1;
            this.deck_ninja.UseVisualStyleBackColor = true;
            this.deck_ninja.Click += new System.EventHandler(this.deck_ninja_Click);
            // 
            // deck_waluigi
            // 
            this.deck_waluigi.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.waluigi_back;
            this.deck_waluigi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_waluigi.Location = new System.Drawing.Point(338, 2);
            this.deck_waluigi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deck_waluigi.Name = "deck_waluigi";
            this.deck_waluigi.Size = new System.Drawing.Size(126, 164);
            this.deck_waluigi.TabIndex = 2;
            this.deck_waluigi.UseVisualStyleBackColor = true;
            this.deck_waluigi.Click += new System.EventHandler(this.deck_waluigi_Click);
            // 
            // deck_george
            // 
            this.deck_george.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.washington_back;
            this.deck_george.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_george.Location = new System.Drawing.Point(506, 2);
            this.deck_george.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deck_george.Name = "deck_george";
            this.deck_george.Size = new System.Drawing.Size(126, 164);
            this.deck_george.TabIndex = 3;
            this.deck_george.UseVisualStyleBackColor = true;
            this.deck_george.Click += new System.EventHandler(this.deck_george_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(322, 348);
            this.button_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(219, 80);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Controls.Add(this.deck_halloween, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deck_canada, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.deck_george, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.deck_waluigi, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.deck_ninja, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(840, 168);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // deck_canada
            // 
            this.deck_canada.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.canada_back;
            this.deck_canada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck_canada.Location = new System.Drawing.Point(674, 2);
            this.deck_canada.Margin = new System.Windows.Forms.Padding(2);
            this.deck_canada.Name = "deck_canada";
            this.deck_canada.Size = new System.Drawing.Size(126, 164);
            this.deck_canada.TabIndex = 4;
            this.deck_canada.UseVisualStyleBackColor = true;
            this.deck_canada.Click += new System.EventHandler(this.deck_canada_Click);
            // 
            // FrmChangeTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmChangeTheme";
            this.Text = "FrmChangeTheme";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deck_halloween;
        private System.Windows.Forms.Button deck_ninja;
        private System.Windows.Forms.Button deck_waluigi;
        private System.Windows.Forms.Button deck_george;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deck_canada;
    }
}