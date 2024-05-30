using System.Windows.Forms;

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
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.imgBack = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnAddMoreMeals = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnAddMenus = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAllMenus = new System.Windows.Forms.Button();
            this.btnAllMeals = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rboMainDish = new System.Windows.Forms.RadioButton();
            this.rboSideDish = new System.Windows.Forms.RadioButton();
            this.rboAppetizer = new System.Windows.Forms.RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1902, 80);
            this.pnlNav.TabIndex = 12;
            // 
            // imgHome
            // 
            this.imgHome.Image = global::SCVZ.Properties.Resources.home;
            this.imgHome.Location = new System.Drawing.Point(99, 11);
            this.imgHome.Margin = new System.Windows.Forms.Padding(2);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(71, 66);
            this.imgHome.TabIndex = 1;
            this.imgHome.TabStop = false;
            this.imgHome.Click += new System.EventHandler(this.imgHome_Click);
            // 
            // imgBack
            // 
            this.imgBack.Image = global::SCVZ.Properties.Resources.back;
            this.imgBack.Location = new System.Drawing.Point(12, 11);
            this.imgBack.Margin = new System.Windows.Forms.Padding(2);
            this.imgBack.Name = "imgBack";
            this.imgBack.Size = new System.Drawing.Size(72, 66);
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
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1902, 85);
            this.pnlLogo.TabIndex = 11;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::SCVZ.Properties.Resources.scvz_logo;
            this.imgLogo.Location = new System.Drawing.Point(0, -1);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(2);
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
            this.pnlFooter.Location = new System.Drawing.Point(0, 942);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1902, 90);
            this.pnlFooter.TabIndex = 10;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnAddMoreMeals);
            this.pnlSidebar.Controls.Add(this.btnAddStaff);
            this.pnlSidebar.Controls.Add(this.btnAddMenus);
            this.pnlSidebar.Controls.Add(this.btnAddMeal);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 165);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 777);
            this.pnlSidebar.TabIndex = 13;
            // 
            // btnAddMoreMeals
            // 
            this.btnAddMoreMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoreMeals.Location = new System.Drawing.Point(42, 298);
            this.btnAddMoreMeals.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMoreMeals.Name = "btnAddMoreMeals";
            this.btnAddMoreMeals.Size = new System.Drawing.Size(304, 41);
            this.btnAddMoreMeals.TabIndex = 30;
            this.btnAddMoreMeals.Text = "Više jela";
            this.btnAddMoreMeals.UseVisualStyleBackColor = true;
            this.btnAddMoreMeals.Click += new System.EventHandler(this.btnAddMoreMeals_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(42, 172);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(304, 41);
            this.btnAddStaff.TabIndex = 29;
            this.btnAddStaff.Text = "Osoblje";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnAddMenus
            // 
            this.btnAddMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMenus.Location = new System.Drawing.Point(42, 108);
            this.btnAddMenus.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMenus.Name = "btnAddMenus";
            this.btnAddMenus.Size = new System.Drawing.Size(304, 41);
            this.btnAddMenus.TabIndex = 28;
            this.btnAddMenus.Text = "Meni";
            this.btnAddMenus.UseVisualStyleBackColor = true;
            this.btnAddMenus.Click += new System.EventHandler(this.btnAddMenus_Click);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeal.Location = new System.Drawing.Point(42, 45);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(304, 41);
            this.btnAddMeal.TabIndex = 27;
            this.btnAddMeal.Text = "Jelo";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // pnlOverview
            // 
            this.pnlOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOverview.Controls.Add(this.dgvDetails);
            this.pnlOverview.Controls.Add(this.dgvPreview);
            this.pnlOverview.Controls.Add(this.pnlFilters);
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(395, 165);
            this.pnlOverview.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(1507, 777);
            this.pnlOverview.TabIndex = 14;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(807, 6);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(372, 766);
            this.dgvDetails.TabIndex = 15;
            // 
            // dgvPreview
            // 
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(6, 6);
            this.dgvPreview.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.RowHeadersWidth = 51;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.Size = new System.Drawing.Size(797, 766);
            this.dgvPreview.TabIndex = 14;
            this.dgvPreview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellClick);
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.btnStaff);
            this.pnlFilters.Controls.Add(this.btnAllMenus);
            this.pnlFilters.Controls.Add(this.btnAllMeals);
            this.pnlFilters.Controls.Add(this.panel1);
            this.pnlFilters.Controls.Add(this.lblFilter);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFilters.Location = new System.Drawing.Point(1185, 0);
            this.pnlFilters.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(322, 777);
            this.pnlFilters.TabIndex = 13;
            this.pnlFilters.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilters_Paint);
            // 
            // btnStaff
            // 
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(44, 470);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(244, 42);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "Zaposlenici";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAllMenus
            // 
            this.btnAllMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMenus.Location = new System.Drawing.Point(44, 402);
            this.btnAllMenus.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllMenus.Name = "btnAllMenus";
            this.btnAllMenus.Size = new System.Drawing.Size(244, 42);
            this.btnAllMenus.TabIndex = 3;
            this.btnAllMenus.Text = "Meniji";
            this.btnAllMenus.UseVisualStyleBackColor = true;
            this.btnAllMenus.Click += new System.EventHandler(this.btnAllMenus_Click);
            // 
            // btnAllMeals
            // 
            this.btnAllMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMeals.Location = new System.Drawing.Point(44, 338);
            this.btnAllMeals.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllMeals.Name = "btnAllMeals";
            this.btnAllMeals.Size = new System.Drawing.Size(244, 42);
            this.btnAllMeals.TabIndex = 2;
            this.btnAllMeals.Text = "Jela";
            this.btnAllMeals.UseVisualStyleBackColor = true;
            this.btnAllMeals.Click += new System.EventHandler(this.btnAllMeals_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rboMainDish);
            this.panel1.Controls.Add(this.rboSideDish);
            this.panel1.Controls.Add(this.rboAppetizer);
            this.panel1.Location = new System.Drawing.Point(44, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 169);
            this.panel1.TabIndex = 1;
            // 
            // rboMainDish
            // 
            this.rboMainDish.AutoSize = true;
            this.rboMainDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboMainDish.Location = new System.Drawing.Point(14, 112);
            this.rboMainDish.Margin = new System.Windows.Forms.Padding(2);
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
            this.rboSideDish.Margin = new System.Windows.Forms.Padding(2);
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
            this.rboAppetizer.Location = new System.Drawing.Point(14, 32);
            this.rboAppetizer.Margin = new System.Windows.Forms.Padding(2);
            this.rboAppetizer.Name = "rboAppetizer";
            this.rboAppetizer.Size = new System.Drawing.Size(89, 24);
            this.rboAppetizer.TabIndex = 0;
            this.rboAppetizer.TabStop = true;
            this.rboAppetizer.Text = "predjelu";
            this.rboAppetizer.UseVisualStyleBackColor = true;
            this.rboAppetizer.CheckedChanged += new System.EventHandler(this.rboAppetizer_CheckedChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(40, 102);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(118, 20);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filtriraj prema:";
            // 
            // FrmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1902, 1032);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlFooter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPreview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Button btnAddMoreMeals;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnAddMenus;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.DataGridView dgvDetails;
    }
}