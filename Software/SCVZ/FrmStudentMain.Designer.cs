namespace SCVZ
{
    partial class FrmStudentMain
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
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlDinner = new System.Windows.Forms.Panel();
            this.lblDinner = new System.Windows.Forms.Label();
            this.pnlLunch = new System.Windows.Forms.Panel();
            this.lblLunch = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.btnOrderStudent = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.imgBack = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlNav.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlDinner.SuspendLayout();
            this.pnlLunch.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
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
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNav_Paint);
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
            this.pnlSidebar.Controls.Add(this.btnOrderHistory);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 165);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 778);
            this.pnlSidebar.TabIndex = 10;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlDinner);
            this.pnlMenu.Controls.Add(this.pnlTitle);
            this.pnlMenu.Controls.Add(this.pnlLunch);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(395, 165);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1507, 778);
            this.pnlMenu.TabIndex = 11;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // pnlDinner
            // 
            this.pnlDinner.Controls.Add(this.lblDinner);
            this.pnlDinner.Location = new System.Drawing.Point(139, 416);
            this.pnlDinner.Name = "pnlDinner";
            this.pnlDinner.Size = new System.Drawing.Size(241, 56);
            this.pnlDinner.TabIndex = 2;
            this.pnlDinner.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDinner_Paint);
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinner.Location = new System.Drawing.Point(18, 10);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(104, 32);
            this.lblDinner.TabIndex = 0;
            this.lblDinner.Text = "Večera";
            // 
            // pnlLunch
            // 
            this.pnlLunch.Controls.Add(this.lblLunch);
            this.pnlLunch.Location = new System.Drawing.Point(139, 142);
            this.pnlLunch.Name = "pnlLunch";
            this.pnlLunch.Size = new System.Drawing.Size(241, 56);
            this.pnlLunch.TabIndex = 1;
            this.pnlLunch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLunch_Paint);
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunch.Location = new System.Drawing.Point(18, 14);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(94, 32);
            this.lblLunch.TabIndex = 0;
            this.lblLunch.Text = "Ručak";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(139, 26);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(919, 80);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(301, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Studentski jelovnik";
            // 
            // pnlOrders
            // 
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrders.Location = new System.Drawing.Point(1579, 165);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(323, 778);
            this.pnlOrders.TabIndex = 12;
            this.pnlOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrders_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnOrderStudent);
            this.panel1.Controls.Add(this.lblCurrentOrder);
            this.panel1.Location = new System.Drawing.Point(34, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 288);
            this.panel1.TabIndex = 0;
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOrder.Location = new System.Drawing.Point(60, 21);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(178, 25);
            this.lblCurrentOrder.TabIndex = 0;
            this.lblCurrentOrder.Text = "Trenutna narudžba";
            // 
            // btnOrderStudent
            // 
            this.btnOrderStudent.BackColor = System.Drawing.Color.White;
            this.btnOrderStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderStudent.Location = new System.Drawing.Point(152, 243);
            this.btnOrderStudent.Name = "btnOrderStudent";
            this.btnOrderStudent.Size = new System.Drawing.Size(168, 42);
            this.btnOrderStudent.TabIndex = 1;
            this.btnOrderStudent.Text = "Nova narudžba";
            this.btnOrderStudent.UseVisualStyleBackColor = false;
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderHistory.Location = new System.Drawing.Point(34, 83);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(211, 54);
            this.btnOrderHistory.TabIndex = 1;
            this.btnOrderHistory.Text = "Povijest naručivanja";
            this.btnOrderHistory.UseVisualStyleBackColor = true;
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
            // FrmStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlFooter);
            this.Name = "FrmStudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNav.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlDinner.ResumeLayout(false);
            this.pnlDinner.PerformLayout();
            this.pnlLunch.ResumeLayout(false);
            this.pnlLunch.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
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
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlLunch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDinner;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.Button btnOrderStudent;
        private System.Windows.Forms.Button btnOrderHistory;
    }
}