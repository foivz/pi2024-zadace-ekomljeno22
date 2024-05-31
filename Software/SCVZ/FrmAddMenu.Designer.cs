namespace SCVZ
{
    partial class FrmAddMenu
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
            this.lblAddMenu = new System.Windows.Forms.Label();
            this.txtMenuId = new System.Windows.Forms.TextBox();
            this.cboMeal01 = new System.Windows.Forms.ComboBox();
            this.cboMeal02 = new System.Windows.Forms.ComboBox();
            this.cboMeal03 = new System.Windows.Forms.ComboBox();
            this.btnAddToDatabase = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboMenuType = new System.Windows.Forms.ComboBox();
            this.txtMenuGiftPoints = new System.Windows.Forms.TextBox();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.txtAveragePrepHours = new System.Windows.Forms.TextBox();
            this.txtAveragePrepMinutes = new System.Windows.Forms.TextBox();
            this.txtAveragePrepSeconds = new System.Windows.Forms.TextBox();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Controls.Add(this.lblAddMenu);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(512, 80);
            this.pnlNav.TabIndex = 23;
            // 
            // lblAddMenu
            // 
            this.lblAddMenu.AutoSize = true;
            this.lblAddMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMenu.ForeColor = System.Drawing.Color.White;
            this.lblAddMenu.Location = new System.Drawing.Point(204, 27);
            this.lblAddMenu.Name = "lblAddMenu";
            this.lblAddMenu.Size = new System.Drawing.Size(80, 36);
            this.lblAddMenu.TabIndex = 0;
            this.lblAddMenu.Text = "Meni";
            // 
            // txtMenuId
            // 
            this.txtMenuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuId.Location = new System.Drawing.Point(142, 98);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.ReadOnly = true;
            this.txtMenuId.Size = new System.Drawing.Size(227, 27);
            this.txtMenuId.TabIndex = 29;
            // 
            // cboMeal01
            // 
            this.cboMeal01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeal01.FormattingEnabled = true;
            this.cboMeal01.Location = new System.Drawing.Point(142, 141);
            this.cboMeal01.Name = "cboMeal01";
            this.cboMeal01.Size = new System.Drawing.Size(227, 28);
            this.cboMeal01.TabIndex = 30;
            this.cboMeal01.Text = "Prvo jelo";
            // 
            // cboMeal02
            // 
            this.cboMeal02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeal02.FormattingEnabled = true;
            this.cboMeal02.Location = new System.Drawing.Point(142, 185);
            this.cboMeal02.Name = "cboMeal02";
            this.cboMeal02.Size = new System.Drawing.Size(227, 28);
            this.cboMeal02.TabIndex = 31;
            this.cboMeal02.Text = "Drugo jelo";
            // 
            // cboMeal03
            // 
            this.cboMeal03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeal03.FormattingEnabled = true;
            this.cboMeal03.Location = new System.Drawing.Point(142, 229);
            this.cboMeal03.Name = "cboMeal03";
            this.cboMeal03.Size = new System.Drawing.Size(227, 28);
            this.cboMeal03.TabIndex = 32;
            this.cboMeal03.Text = "Treće jelo";
            // 
            // btnAddToDatabase
            // 
            this.btnAddToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToDatabase.Location = new System.Drawing.Point(356, 499);
            this.btnAddToDatabase.Name = "btnAddToDatabase";
            this.btnAddToDatabase.Size = new System.Drawing.Size(144, 43);
            this.btnAddToDatabase.TabIndex = 34;
            this.btnAddToDatabase.Text = "Dodaj u bazu";
            this.btnAddToDatabase.UseVisualStyleBackColor = true;
            this.btnAddToDatabase.Click += new System.EventHandler(this.btnAddToDatabase_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 43);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboMenuType
            // 
            this.cboMenuType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMenuType.FormattingEnabled = true;
            this.cboMenuType.Location = new System.Drawing.Point(142, 272);
            this.cboMenuType.Name = "cboMenuType";
            this.cboMenuType.Size = new System.Drawing.Size(227, 28);
            this.cboMenuType.TabIndex = 35;
            this.cboMenuType.Text = "Vrsta menija";
            // 
            // txtMenuGiftPoints
            // 
            this.txtMenuGiftPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuGiftPoints.Location = new System.Drawing.Point(142, 316);
            this.txtMenuGiftPoints.Name = "txtMenuGiftPoints";
            this.txtMenuGiftPoints.Size = new System.Drawing.Size(227, 27);
            this.txtMenuGiftPoints.TabIndex = 36;
            this.txtMenuGiftPoints.Text = "Iznos poklon bodova";
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuPrice.Location = new System.Drawing.Point(142, 359);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(227, 27);
            this.txtMenuPrice.TabIndex = 37;
            this.txtMenuPrice.Text = "Cijena menija";
            // 
            // txtAveragePrepHours
            // 
            this.txtAveragePrepHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAveragePrepHours.Location = new System.Drawing.Point(142, 412);
            this.txtAveragePrepHours.Name = "txtAveragePrepHours";
            this.txtAveragePrepHours.Size = new System.Drawing.Size(72, 27);
            this.txtAveragePrepHours.TabIndex = 38;
            this.txtAveragePrepHours.Text = "Sati";
            // 
            // txtAveragePrepMinutes
            // 
            this.txtAveragePrepMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAveragePrepMinutes.Location = new System.Drawing.Point(220, 412);
            this.txtAveragePrepMinutes.Name = "txtAveragePrepMinutes";
            this.txtAveragePrepMinutes.Size = new System.Drawing.Size(72, 27);
            this.txtAveragePrepMinutes.TabIndex = 39;
            this.txtAveragePrepMinutes.Text = "Minute";
            // 
            // txtAveragePrepSeconds
            // 
            this.txtAveragePrepSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAveragePrepSeconds.Location = new System.Drawing.Point(297, 412);
            this.txtAveragePrepSeconds.Name = "txtAveragePrepSeconds";
            this.txtAveragePrepSeconds.Size = new System.Drawing.Size(72, 27);
            this.txtAveragePrepSeconds.TabIndex = 40;
            this.txtAveragePrepSeconds.Text = "Sekunde";
            // 
            // FrmAddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.txtAveragePrepSeconds);
            this.Controls.Add(this.txtAveragePrepMinutes);
            this.Controls.Add(this.txtAveragePrepHours);
            this.Controls.Add(this.txtMenuPrice);
            this.Controls.Add(this.txtMenuGiftPoints);
            this.Controls.Add(this.cboMenuType);
            this.Controls.Add(this.btnAddToDatabase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboMeal03);
            this.Controls.Add(this.cboMeal02);
            this.Controls.Add(this.cboMeal01);
            this.Controls.Add(this.txtMenuId);
            this.Controls.Add(this.pnlNav);
            this.Name = "FrmAddMenu";
            this.Text = "FrmAddMenu";
            this.Load += new System.EventHandler(this.FrmAddMenu_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblAddMenu;
        private System.Windows.Forms.TextBox txtMenuId;
        private System.Windows.Forms.ComboBox cboMeal01;
        private System.Windows.Forms.ComboBox cboMeal02;
        private System.Windows.Forms.ComboBox cboMeal03;
        private System.Windows.Forms.Button btnAddToDatabase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboMenuType;
        private System.Windows.Forms.TextBox txtMenuGiftPoints;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.TextBox txtAveragePrepHours;
        private System.Windows.Forms.TextBox txtAveragePrepMinutes;
        private System.Windows.Forms.TextBox txtAveragePrepSeconds;
    }
}