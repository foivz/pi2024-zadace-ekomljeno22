namespace SCVZ
{
    partial class FrmAddOrder
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtOrderServer = new System.Windows.Forms.TextBox();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdMenu = new System.Windows.Forms.TextBox();
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
            this.pnlNav.TabIndex = 18;
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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 41);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(333, 491);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(153, 41);
            this.btnOrder.TabIndex = 20;
            this.btnOrder.Text = "Naruči";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(135, 169);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(227, 30);
            this.txtOrderId.TabIndex = 30;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // txtOrderServer
            // 
            this.txtOrderServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderServer.Location = new System.Drawing.Point(135, 417);
            this.txtOrderServer.Name = "txtOrderServer";
            this.txtOrderServer.ReadOnly = true;
            this.txtOrderServer.Size = new System.Drawing.Size(227, 30);
            this.txtOrderServer.TabIndex = 32;
            this.txtOrderServer.TextChanged += new System.EventHandler(this.txtOrderServer_TextChanged);
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderPrice.Location = new System.Drawing.Point(135, 356);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.ReadOnly = true;
            this.txtOrderPrice.Size = new System.Drawing.Size(227, 30);
            this.txtOrderPrice.TabIndex = 33;
            this.txtOrderPrice.TextChanged += new System.EventHandler(this.txtOrderPrice_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(135, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "Odaberi Meni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdMenu
            // 
            this.txtIdMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMenu.Location = new System.Drawing.Point(135, 292);
            this.txtIdMenu.Name = "txtIdMenu";
            this.txtIdMenu.ReadOnly = true;
            this.txtIdMenu.Size = new System.Drawing.Size(227, 34);
            this.txtIdMenu.TabIndex = 35;
            // 
            // FrmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.txtIdMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOrderPrice);
            this.Controls.Add(this.txtOrderServer);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlNav);
            this.Name = "FrmAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddOrder";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblNewOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtOrderServer;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdMenu;
    }
}