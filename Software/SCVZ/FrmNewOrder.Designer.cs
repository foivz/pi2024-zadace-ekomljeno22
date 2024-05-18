namespace SCVZ
{
    partial class FrmNewOrder
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
            // FrmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlNav);
            this.Name = "FrmNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewOrder";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblNewOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
    }
}