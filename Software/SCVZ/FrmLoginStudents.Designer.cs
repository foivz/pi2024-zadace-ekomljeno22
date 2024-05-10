namespace SCVZ
{
    partial class FrmLoginStudents
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.imgBack = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Panel();
            this.img2FAIcon = new System.Windows.Forms.PictureBox();
            this.imgPasswordIcon = new System.Windows.Forms.PictureBox();
            this.imgUserIcon = new System.Windows.Forms.PictureBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.txt2FA = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.txtUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img2FAIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Controls.Add(this.imgHome);
            this.pnlNav.Controls.Add(this.imgBack);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 85);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1902, 80);
            this.pnlNav.TabIndex = 9;
            // 
            // imgHome
            // 
            this.imgHome.Image = global::SCVZ.Properties.Resources.home;
            this.imgHome.Location = new System.Drawing.Point(99, 11);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(71, 66);
            this.imgHome.TabIndex = 1;
            this.imgHome.TabStop = false;
            this.imgHome.Click += new System.EventHandler(this.imgHome_Click);
            // 
            // imgBack
            // 
            this.imgBack.Image = global::SCVZ.Properties.Resources.back;
            this.imgBack.Location = new System.Drawing.Point(13, 11);
            this.imgBack.Name = "imgBack";
            this.imgBack.Size = new System.Drawing.Size(73, 66);
            this.imgBack.TabIndex = 0;
            this.imgBack.TabStop = false;
            this.imgBack.Click += new System.EventHandler(this.imgBack_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLogo.BackColor = System.Drawing.Color.Black;
            this.pnlLogo.Controls.Add(this.imgLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1902, 85);
            this.pnlLogo.TabIndex = 8;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::SCVZ.Properties.Resources.scvz_logo;
            this.imgLogo.Location = new System.Drawing.Point(0, -1);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(570, 82);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Location = new System.Drawing.Point(-299, 938);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(2500, 90);
            this.pnlFooter.TabIndex = 7;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudenti.Location = new System.Drawing.Point(1239, 168);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(219, 46);
            this.lblStudenti.TabIndex = 11;
            this.lblStudenti.Text = "STUDENTI";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtUsername.BackColor = System.Drawing.Color.Silver;
            this.txtUsername.Controls.Add(this.img2FAIcon);
            this.txtUsername.Controls.Add(this.imgPasswordIcon);
            this.txtUsername.Controls.Add(this.imgUserIcon);
            this.txtUsername.Controls.Add(this.btnPrijaviSe);
            this.txtUsername.Controls.Add(this.txt2FA);
            this.txtUsername.Controls.Add(this.txtPassword);
            this.txtUsername.Controls.Add(this.textBox1);
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(779, 164);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(429, 778);
            this.txtUsername.TabIndex = 10;
            // 
            // img2FAIcon
            // 
            this.img2FAIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img2FAIcon.BackColor = System.Drawing.Color.Transparent;
            this.img2FAIcon.Image = global::SCVZ.Properties.Resources._2_FA;
            this.img2FAIcon.Location = new System.Drawing.Point(333, 430);
            this.img2FAIcon.Name = "img2FAIcon";
            this.img2FAIcon.Size = new System.Drawing.Size(71, 38);
            this.img2FAIcon.TabIndex = 6;
            this.img2FAIcon.TabStop = false;
            // 
            // imgPasswordIcon
            // 
            this.imgPasswordIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgPasswordIcon.Image = global::SCVZ.Properties.Resources.image_5;
            this.imgPasswordIcon.Location = new System.Drawing.Point(333, 306);
            this.imgPasswordIcon.Name = "imgPasswordIcon";
            this.imgPasswordIcon.Size = new System.Drawing.Size(71, 72);
            this.imgPasswordIcon.TabIndex = 5;
            this.imgPasswordIcon.TabStop = false;
            // 
            // imgUserIcon
            // 
            this.imgUserIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgUserIcon.Image = global::SCVZ.Properties.Resources.image_6;
            this.imgUserIcon.Location = new System.Drawing.Point(333, 218);
            this.imgUserIcon.Name = "imgUserIcon";
            this.imgUserIcon.Size = new System.Drawing.Size(71, 72);
            this.imgUserIcon.TabIndex = 4;
            this.imgUserIcon.TabStop = false;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSe.ForeColor = System.Drawing.Color.Black;
            this.btnPrijaviSe.Location = new System.Drawing.Point(128, 516);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(189, 43);
            this.btnPrijaviSe.TabIndex = 3;
            this.btnPrijaviSe.Text = "PRIJAVI SE";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // txt2FA
            // 
            this.txt2FA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt2FA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txt2FA.Location = new System.Drawing.Point(56, 415);
            this.txt2FA.Margin = new System.Windows.Forms.Padding(8);
            this.txt2FA.MaxLength = 6;
            this.txt2FA.Name = "txt2FA";
            this.txt2FA.Size = new System.Drawing.Size(261, 38);
            this.txt2FA.TabIndex = 2;
            this.txt2FA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(56, 324);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(15);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(261, 38);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Lozinka";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.textBox1.Location = new System.Drawing.Point(56, 236);
            this.textBox1.Margin = new System.Windows.Forms.Padding(15);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Korisničko ime";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmLoginStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lblStudenti);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlFooter);
            this.Name = "FrmLoginStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoginStudents";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.txtUsername.ResumeLayout(false);
            this.txtUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img2FAIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox imgHome;
        private System.Windows.Forms.PictureBox imgBack;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblStudenti;
        private System.Windows.Forms.Panel txtUsername;
        private System.Windows.Forms.PictureBox img2FAIcon;
        private System.Windows.Forms.PictureBox imgPasswordIcon;
        private System.Windows.Forms.PictureBox imgUserIcon;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.TextBox txt2FA;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox textBox1;
    }
}