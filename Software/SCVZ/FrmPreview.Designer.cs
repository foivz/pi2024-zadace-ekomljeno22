namespace SCVZ
{
    partial class FrmPreview
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
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnAllMenus = new System.Windows.Forms.Button();
            this.btnAllMeals = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rboMainDish = new System.Windows.Forms.RadioButton();
            this.rboSideDish = new System.Windows.Forms.RadioButton();
            this.rboAppetizer = new System.Windows.Forms.RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.imgBack = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlNav.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.pnlFilters.SuspendLayout();
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
            this.pnlNav.TabIndex = 12;
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
            this.pnlLogo.TabIndex = 11;
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
            this.pnlFooter.TabIndex = 10;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 165);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 778);
            this.pnlSidebar.TabIndex = 13;
            // 
            // pnlOverview
            // 
            this.pnlOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOverview.Controls.Add(this.pnlFilters);
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(395, 165);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(1507, 778);
            this.pnlOverview.TabIndex = 14;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.btnAllMenus);
            this.pnlFilters.Controls.Add(this.btnAllMeals);
            this.pnlFilters.Controls.Add(this.panel1);
            this.pnlFilters.Controls.Add(this.lblFilter);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFilters.Location = new System.Drawing.Point(1184, 0);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(323, 778);
            this.pnlFilters.TabIndex = 13;
            this.pnlFilters.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilters_Paint);
            // 
            // btnAllMenus
            // 
            this.btnAllMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMenus.Location = new System.Drawing.Point(44, 403);
            this.btnAllMenus.Name = "btnAllMenus";
            this.btnAllMenus.Size = new System.Drawing.Size(244, 42);
            this.btnAllMenus.TabIndex = 3;
            this.btnAllMenus.Text = "Meniji";
            this.btnAllMenus.UseVisualStyleBackColor = true;
            // 
            // btnAllMeals
            // 
            this.btnAllMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMeals.Location = new System.Drawing.Point(44, 338);
            this.btnAllMeals.Name = "btnAllMeals";
            this.btnAllMeals.Size = new System.Drawing.Size(244, 42);
            this.btnAllMeals.TabIndex = 2;
            this.btnAllMeals.Text = "Jela";
            this.btnAllMeals.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rboMainDish);
            this.panel1.Controls.Add(this.rboSideDish);
            this.panel1.Controls.Add(this.rboAppetizer);
            this.panel1.Location = new System.Drawing.Point(44, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 169);
            this.panel1.TabIndex = 1;
            // 
            // rboMainDish
            // 
            this.rboMainDish.AutoSize = true;
            this.rboMainDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboMainDish.Location = new System.Drawing.Point(14, 113);
            this.rboMainDish.Name = "rboMainDish";
            this.rboMainDish.Size = new System.Drawing.Size(123, 24);
            this.rboMainDish.TabIndex = 2;
            this.rboMainDish.TabStop = true;
            this.rboMainDish.Text = "glavnom jelu";
            this.rboMainDish.UseVisualStyleBackColor = true;
            // 
            // rboSideDish
            // 
            this.rboSideDish.AutoSize = true;
            this.rboSideDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboSideDish.Location = new System.Drawing.Point(14, 72);
            this.rboSideDish.Name = "rboSideDish";
            this.rboSideDish.Size = new System.Drawing.Size(80, 24);
            this.rboSideDish.TabIndex = 1;
            this.rboSideDish.TabStop = true;
            this.rboSideDish.Text = "prilogu";
            this.rboSideDish.UseVisualStyleBackColor = true;
            // 
            // rboAppetizer
            // 
            this.rboAppetizer.AutoSize = true;
            this.rboAppetizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboAppetizer.Location = new System.Drawing.Point(14, 33);
            this.rboAppetizer.Name = "rboAppetizer";
            this.rboAppetizer.Size = new System.Drawing.Size(89, 24);
            this.rboAppetizer.TabIndex = 0;
            this.rboAppetizer.TabStop = true;
            this.rboAppetizer.Text = "predjelu";
            this.rboAppetizer.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(40, 103);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(118, 20);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filtriraj prema:";
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
            // FrmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlFooter);
            this.Name = "FrmPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPreview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNav.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox imgHome;
        private System.Windows.Forms.PictureBox imgBack;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.RadioButton rboSideDish;
        private System.Windows.Forms.RadioButton rboAppetizer;
        private System.Windows.Forms.Button btnAllMenus;
        private System.Windows.Forms.Button btnAllMeals;
        private System.Windows.Forms.RadioButton rboMainDish;
    }
}