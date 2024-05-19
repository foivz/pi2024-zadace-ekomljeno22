namespace SCVZ
{
    partial class FrmAddMeal
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
            this.lblAddMeal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.txtMealPrice = new System.Windows.Forms.TextBox();
            this.txtMealGiftPointsCount = new System.Windows.Forms.TextBox();
            this.cboMealType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddToDatabase = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Controls.Add(this.lblAddMeal);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(512, 80);
            this.pnlNav.TabIndex = 22;
            // 
            // lblAddMeal
            // 
            this.lblAddMeal.AutoSize = true;
            this.lblAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMeal.ForeColor = System.Drawing.Color.White;
            this.lblAddMeal.Location = new System.Drawing.Point(193, 25);
            this.lblAddMeal.Name = "lblAddMeal";
            this.lblAddMeal.Size = new System.Drawing.Size(70, 36);
            this.lblAddMeal.TabIndex = 0;
            this.lblAddMeal.Text = "Jelo";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(136, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(227, 34);
            this.textBox1.TabIndex = 23;
            // 
            // txtMealName
            // 
            this.txtMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealName.Location = new System.Drawing.Point(136, 228);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(227, 34);
            this.txtMealName.TabIndex = 24;
            this.txtMealName.Text = "Naziv jela";
            // 
            // txtMealPrice
            // 
            this.txtMealPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealPrice.Location = new System.Drawing.Point(136, 334);
            this.txtMealPrice.Name = "txtMealPrice";
            this.txtMealPrice.Size = new System.Drawing.Size(227, 34);
            this.txtMealPrice.TabIndex = 26;
            this.txtMealPrice.Text = "Cijena";
            this.txtMealPrice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtMealGiftPointsCount
            // 
            this.txtMealGiftPointsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealGiftPointsCount.Location = new System.Drawing.Point(136, 386);
            this.txtMealGiftPointsCount.Name = "txtMealGiftPointsCount";
            this.txtMealGiftPointsCount.Size = new System.Drawing.Size(227, 34);
            this.txtMealGiftPointsCount.TabIndex = 27;
            this.txtMealGiftPointsCount.Text = "Broj poklon bodova";
            // 
            // cboMealType
            // 
            this.cboMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMealType.FormattingEnabled = true;
            this.cboMealType.Location = new System.Drawing.Point(136, 278);
            this.cboMealType.Name = "cboMealType";
            this.cboMealType.Size = new System.Drawing.Size(227, 37);
            this.cboMealType.TabIndex = 28;
            this.cboMealType.Text = "Vrsta jela";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 43);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddToDatabase
            // 
            this.btnAddToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToDatabase.Location = new System.Drawing.Point(356, 499);
            this.btnAddToDatabase.Name = "btnAddToDatabase";
            this.btnAddToDatabase.Size = new System.Drawing.Size(144, 43);
            this.btnAddToDatabase.TabIndex = 30;
            this.btnAddToDatabase.Text = "Dodaj u bazu";
            this.btnAddToDatabase.UseVisualStyleBackColor = true;
            // 
            // FrmAddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.btnAddToDatabase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboMealType);
            this.Controls.Add(this.txtMealGiftPointsCount);
            this.Controls.Add(this.txtMealPrice);
            this.Controls.Add(this.txtMealName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlNav);
            this.Name = "FrmAddMeal";
            this.Text = "FrmAddMeal";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblAddMeal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMealName;
        private System.Windows.Forms.TextBox txtMealPrice;
        private System.Windows.Forms.TextBox txtMealGiftPointsCount;
        private System.Windows.Forms.ComboBox cboMealType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddToDatabase;
    }
}