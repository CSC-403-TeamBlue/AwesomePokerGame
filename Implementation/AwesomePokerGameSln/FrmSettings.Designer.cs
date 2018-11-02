namespace AwesomePokerGameSln
{
    partial class FrmSettings
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
            this.button_fullscreen = new System.Windows.Forms.Button();
            this.button_change_theme = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_fullscreen
            // 
            this.button_fullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_fullscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_fullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fullscreen.Location = new System.Drawing.Point(3, 3);
            this.button_fullscreen.Name = "button_fullscreen";
            this.button_fullscreen.Size = new System.Drawing.Size(468, 144);
            this.button_fullscreen.TabIndex = 0;
            this.button_fullscreen.Text = "Toggle Fullscreen";
            this.button_fullscreen.UseVisualStyleBackColor = false;
            this.button_fullscreen.Click += new System.EventHandler(this.button_fullscreen_Click);
            // 
            // button_change_theme
            // 
            this.button_change_theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_change_theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_change_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_theme.Location = new System.Drawing.Point(477, 3);
            this.button_change_theme.Name = "button_change_theme";
            this.button_change_theme.Size = new System.Drawing.Size(469, 144);
            this.button_change_theme.TabIndex = 1;
            this.button_change_theme.Text = "Change Theme";
            this.button_change_theme.UseVisualStyleBackColor = false;
            this.button_change_theme.Click += new System.EventHandler(this.button_change_theme_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(952, 3);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(470, 144);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.button_fullscreen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_back, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_change_theme, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 711);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1425, 150);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1425, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_fullscreen;
        private System.Windows.Forms.Button button_change_theme;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}