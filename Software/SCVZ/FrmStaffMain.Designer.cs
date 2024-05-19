namespace SCVZ
{
    partial class FrmStaffMain
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnAddFrm = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.pnlCurrentOrders = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlSidebar.SuspendLayout();
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
            this.pnlFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 943);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1902, 90);
            this.pnlFooter.TabIndex = 7;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnStatus);
            this.pnlSidebar.Controls.Add(this.btnPreview);
            this.pnlSidebar.Controls.Add(this.btnStatistics);
            this.pnlSidebar.Controls.Add(this.btnAddFrm);
            this.pnlSidebar.Controls.Add(this.btnNewOrder);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 165);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 778);
            this.pnlSidebar.TabIndex = 11;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(70, 348);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(227, 67);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Pregled";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Location = new System.Drawing.Point(70, 244);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(227, 67);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistika";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnAddFrm
            // 
            this.btnAddFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFrm.Location = new System.Drawing.Point(70, 138);
            this.btnAddFrm.Name = "btnAddFrm";
            this.btnAddFrm.Size = new System.Drawing.Size(227, 67);
            this.btnAddFrm.TabIndex = 1;
            this.btnAddFrm.Text = "Dodaj...";
            this.btnAddFrm.UseVisualStyleBackColor = true;
            this.btnAddFrm.Click += new System.EventHandler(this.btnAddFrm_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(70, 31);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(227, 67);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "Nova narudžba";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // pnlCurrentOrders
            // 
            this.pnlCurrentOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCurrentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCurrentOrders.Location = new System.Drawing.Point(395, 165);
            this.pnlCurrentOrders.Name = "pnlCurrentOrders";
            this.pnlCurrentOrders.Size = new System.Drawing.Size(1507, 778);
            this.pnlCurrentOrders.TabIndex = 12;
            // 
            // btnStatus
            // 
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(70, 583);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(227, 67);
            this.btnStatus.TabIndex = 4;
            this.btnStatus.Text = "Status menze";
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // FrmStaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlCurrentOrders);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlFooter);
            this.Name = "FrmStaffMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStaffMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHome;
        private System.Windows.Forms.PictureBox imgBack;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCurrentOrders;
        private System.Windows.Forms.Button btnAddFrm;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnStatus;
    }
}