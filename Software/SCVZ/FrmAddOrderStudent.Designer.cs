namespace SCVZ
{
    partial class FrmAddOrderStudent
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
            this.lblNewOrder = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtIdMenu = new System.Windows.Forms.TextBox();
            this.btnChooseMenu = new System.Windows.Forms.Button();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.txtOrderServer = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Controls.Add(this.lblNewOrder);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(512, 80);
            this.pnlNav.TabIndex = 36;
            // 
            // lblNewOrder
            // 
            this.lblNewOrder.AutoSize = true;
            this.lblNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrder.ForeColor = System.Drawing.Color.White;
            this.lblNewOrder.Location = new System.Drawing.Point(144, 24);
            this.lblNewOrder.Name = "lblNewOrder";
            this.lblNewOrder.Size = new System.Drawing.Size(218, 36);
            this.lblNewOrder.TabIndex = 0;
            this.lblNewOrder.Text = "Nova narudžba";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(333, 491);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(153, 41);
            this.btnOrder.TabIndex = 38;
            this.btnOrder.Text = "Naruči";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 41);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(143, 354);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(227, 27);
            this.txtStudentId.TabIndex = 57;
            // 
            // txtIdMenu
            // 
            this.txtIdMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMenu.Location = new System.Drawing.Point(143, 202);
            this.txtIdMenu.Name = "txtIdMenu";
            this.txtIdMenu.ReadOnly = true;
            this.txtIdMenu.Size = new System.Drawing.Size(227, 27);
            this.txtIdMenu.TabIndex = 56;
            // 
            // btnChooseMenu
            // 
            this.btnChooseMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseMenu.Location = new System.Drawing.Point(143, 152);
            this.btnChooseMenu.Name = "btnChooseMenu";
            this.btnChooseMenu.Size = new System.Drawing.Size(227, 27);
            this.btnChooseMenu.TabIndex = 55;
            this.btnChooseMenu.Text = "Odaberi Meni";
            this.btnChooseMenu.UseVisualStyleBackColor = true;
            this.btnChooseMenu.Click += new System.EventHandler(this.btnChooseMenu_Click);
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderPrice.Location = new System.Drawing.Point(143, 252);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.ReadOnly = true;
            this.txtOrderPrice.Size = new System.Drawing.Size(227, 27);
            this.txtOrderPrice.TabIndex = 54;
            // 
            // txtOrderServer
            // 
            this.txtOrderServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderServer.Location = new System.Drawing.Point(143, 303);
            this.txtOrderServer.Name = "txtOrderServer";
            this.txtOrderServer.ReadOnly = true;
            this.txtOrderServer.Size = new System.Drawing.Size(227, 27);
            this.txtOrderServer.TabIndex = 53;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(143, 106);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(227, 27);
            this.txtOrderId.TabIndex = 52;
            // 
            // FrmAddOrderStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtIdMenu);
            this.Controls.Add(this.btnChooseMenu);
            this.Controls.Add(this.txtOrderPrice);
            this.Controls.Add(this.txtOrderServer);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmAddOrderStudent";
            this.Text = "FrmAddOrderStudent";
            this.Load += new System.EventHandler(this.FrmAddOrderStudent_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblNewOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtIdMenu;
        private System.Windows.Forms.Button btnChooseMenu;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.TextBox txtOrderServer;
        private System.Windows.Forms.TextBox txtOrderId;
    }
}