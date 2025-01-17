namespace SCVZ
{
    partial class FrmAddStaff
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
            this.lblAddStaff = new System.Windows.Forms.Label();
            this.btnAddToDatabase = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboStaffPosition = new System.Windows.Forms.ComboBox();
            this.txtStaffFirstName = new System.Windows.Forms.TextBox();
            this.txtStaffLastName = new System.Windows.Forms.TextBox();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassCode = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Controls.Add(this.lblAddStaff);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(512, 80);
            this.pnlNav.TabIndex = 23;
            // 
            // lblAddStaff
            // 
            this.lblAddStaff.AutoSize = true;
            this.lblAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStaff.ForeColor = System.Drawing.Color.White;
            this.lblAddStaff.Location = new System.Drawing.Point(201, 24);
            this.lblAddStaff.Name = "lblAddStaff";
            this.lblAddStaff.Size = new System.Drawing.Size(116, 36);
            this.lblAddStaff.TabIndex = 0;
            this.lblAddStaff.Text = "Osoblje";
            // 
            // btnAddToDatabase
            // 
            this.btnAddToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToDatabase.Location = new System.Drawing.Point(356, 421);
            this.btnAddToDatabase.Name = "btnAddToDatabase";
            this.btnAddToDatabase.Size = new System.Drawing.Size(144, 43);
            this.btnAddToDatabase.TabIndex = 32;
            this.btnAddToDatabase.Text = "Dodaj u bazu";
            this.btnAddToDatabase.UseVisualStyleBackColor = true;
            this.btnAddToDatabase.Click += new System.EventHandler(this.btnAddToDatabase_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 43);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboStaffPosition
            // 
            this.cboStaffPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffPosition.FormattingEnabled = true;
            this.cboStaffPosition.Location = new System.Drawing.Point(187, 351);
            this.cboStaffPosition.Name = "cboStaffPosition";
            this.cboStaffPosition.Size = new System.Drawing.Size(191, 33);
            this.cboStaffPosition.TabIndex = 35;
            this.cboStaffPosition.Text = "Pozicija";
            // 
            // txtStaffFirstName
            // 
            this.txtStaffFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffFirstName.Location = new System.Drawing.Point(187, 147);
            this.txtStaffFirstName.Name = "txtStaffFirstName";
            this.txtStaffFirstName.Size = new System.Drawing.Size(191, 30);
            this.txtStaffFirstName.TabIndex = 34;
            this.txtStaffFirstName.Text = "Ime";
            // 
            // txtStaffLastName
            // 
            this.txtStaffLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffLastName.Location = new System.Drawing.Point(187, 198);
            this.txtStaffLastName.Name = "txtStaffLastName";
            this.txtStaffLastName.Size = new System.Drawing.Size(191, 30);
            this.txtStaffLastName.TabIndex = 36;
            this.txtStaffLastName.Text = "Prezime";
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffPassword.Location = new System.Drawing.Point(187, 300);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.PasswordChar = '*';
            this.txtStaffPassword.Size = new System.Drawing.Size(191, 30);
            this.txtStaffPassword.TabIndex = 37;
            this.txtStaffPassword.Text = "Lozinka";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(187, 246);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(191, 30);
            this.txtUsername.TabIndex = 38;
            this.txtUsername.Text = "Korisničko ime";
            // 
            // txtPassCode
            // 
            this.txtPassCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCode.Location = new System.Drawing.Point(187, 97);
            this.txtPassCode.Name = "txtPassCode";
            this.txtPassCode.PasswordChar = '*';
            this.txtPassCode.Size = new System.Drawing.Size(191, 30);
            this.txtPassCode.TabIndex = 39;
            this.txtPassCode.Text = "PassCode";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(91, 104);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(59, 20);
            this.lblToken.TabIndex = 40;
            this.lblToken.Text = "Token:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(91, 307);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 20);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "Lozinka:";
            // 
            // FrmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(512, 481);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.txtPassCode);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtStaffPassword);
            this.Controls.Add(this.txtStaffLastName);
            this.Controls.Add(this.cboStaffPosition);
            this.Controls.Add(this.txtStaffFirstName);
            this.Controls.Add(this.btnAddToDatabase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlNav);
            this.Name = "FrmAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddStaff";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblAddStaff;
        private System.Windows.Forms.Button btnAddToDatabase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboStaffPosition;
        private System.Windows.Forms.TextBox txtStaffFirstName;
        private System.Windows.Forms.TextBox txtStaffLastName;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassCode;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblPassword;
    }
}