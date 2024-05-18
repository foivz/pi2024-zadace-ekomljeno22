namespace SCVZ
{
    partial class FrmStatistics
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblConversion = new System.Windows.Forms.Label();
            this.btnFilterAllTime = new System.Windows.Forms.Button();
            this.btnFilterThisMonth = new System.Windows.Forms.Button();
            this.btnFilterThisWeek = new System.Windows.Forms.Button();
            this.btnFilterToday = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnSortNbrOrders = new System.Windows.Forms.Button();
            this.btnSortTotalRating = new System.Windows.Forms.Button();
            this.btnSortPreparationTime = new System.Windows.Forms.Button();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlFilters.SuspendLayout();
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
            this.pnlNav.TabIndex = 17;
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
            this.pnlLogo.TabIndex = 16;
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
            this.pnlFooter.TabIndex = 15;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnFilterToday);
            this.pnlSidebar.Controls.Add(this.btnGenerateReport);
            this.pnlSidebar.Controls.Add(this.numericUpDown1);
            this.pnlSidebar.Controls.Add(this.lblConversion);
            this.pnlSidebar.Controls.Add(this.btnFilterAllTime);
            this.pnlSidebar.Controls.Add(this.btnFilterThisMonth);
            this.pnlSidebar.Controls.Add(this.btnFilterThisWeek);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 165);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 778);
            this.pnlSidebar.TabIndex = 18;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(40, 602);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(184, 45);
            this.btnGenerateReport.TabIndex = 6;
            this.btnGenerateReport.Text = "Generiraj izvještaj";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(40, 521);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(271, 27);
            this.numericUpDown1.TabIndex = 5;
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversion.Location = new System.Drawing.Point(36, 470);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(275, 20);
            this.lblConversion.TabIndex = 4;
            this.lblConversion.Text = "Konverzija poklon bodova u kupone:";
            // 
            // btnFilterAllTime
            // 
            this.btnFilterAllTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterAllTime.Location = new System.Drawing.Point(70, 348);
            this.btnFilterAllTime.Name = "btnFilterAllTime";
            this.btnFilterAllTime.Size = new System.Drawing.Size(227, 67);
            this.btnFilterAllTime.TabIndex = 3;
            this.btnFilterAllTime.Text = "Cijelo vrijeme";
            this.btnFilterAllTime.UseVisualStyleBackColor = true;
            this.btnFilterAllTime.Click += new System.EventHandler(this.btnFilterAllTime_Click);
            // 
            // btnFilterThisMonth
            // 
            this.btnFilterThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterThisMonth.Location = new System.Drawing.Point(70, 244);
            this.btnFilterThisMonth.Name = "btnFilterThisMonth";
            this.btnFilterThisMonth.Size = new System.Drawing.Size(227, 67);
            this.btnFilterThisMonth.TabIndex = 2;
            this.btnFilterThisMonth.Text = "Ovaj mjesec";
            this.btnFilterThisMonth.UseVisualStyleBackColor = true;
            // 
            // btnFilterThisWeek
            // 
            this.btnFilterThisWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterThisWeek.Location = new System.Drawing.Point(70, 138);
            this.btnFilterThisWeek.Name = "btnFilterThisWeek";
            this.btnFilterThisWeek.Size = new System.Drawing.Size(227, 67);
            this.btnFilterThisWeek.TabIndex = 1;
            this.btnFilterThisWeek.Text = "Ovaj tjedan";
            this.btnFilterThisWeek.UseVisualStyleBackColor = true;
            this.btnFilterThisWeek.Click += new System.EventHandler(this.btnFilterThisWeek_Click);
            // 
            // btnFilterToday
            // 
            this.btnFilterToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterToday.Location = new System.Drawing.Point(70, 31);
            this.btnFilterToday.Name = "btnFilterToday";
            this.btnFilterToday.Size = new System.Drawing.Size(227, 67);
            this.btnFilterToday.TabIndex = 0;
            this.btnFilterToday.Text = "Danas";
            this.btnFilterToday.UseVisualStyleBackColor = true;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(438, 21);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(120, 20);
            this.lblSort.TabIndex = 0;
            this.lblSort.Text = "Sortiraj prema:";
            // 
            // btnSortNbrOrders
            // 
            this.btnSortNbrOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNbrOrders.Location = new System.Drawing.Point(585, 15);
            this.btnSortNbrOrders.Name = "btnSortNbrOrders";
            this.btnSortNbrOrders.Size = new System.Drawing.Size(157, 33);
            this.btnSortNbrOrders.TabIndex = 0;
            this.btnSortNbrOrders.Text = "broju narudžbi";
            this.btnSortNbrOrders.UseVisualStyleBackColor = true;
            // 
            // btnSortTotalRating
            // 
            this.btnSortTotalRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortTotalRating.Location = new System.Drawing.Point(763, 15);
            this.btnSortTotalRating.Name = "btnSortTotalRating";
            this.btnSortTotalRating.Size = new System.Drawing.Size(157, 33);
            this.btnSortTotalRating.TabIndex = 1;
            this.btnSortTotalRating.Text = "ukupnoj ocjeni";
            this.btnSortTotalRating.UseVisualStyleBackColor = true;
            // 
            // btnSortPreparationTime
            // 
            this.btnSortPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortPreparationTime.Location = new System.Drawing.Point(940, 15);
            this.btnSortPreparationTime.Name = "btnSortPreparationTime";
            this.btnSortPreparationTime.Size = new System.Drawing.Size(157, 33);
            this.btnSortPreparationTime.TabIndex = 3;
            this.btnSortPreparationTime.Text = "vremenu pripreme";
            this.btnSortPreparationTime.UseVisualStyleBackColor = true;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.btnSortTotalRating);
            this.pnlFilters.Controls.Add(this.btnSortNbrOrders);
            this.pnlFilters.Controls.Add(this.lblSort);
            this.pnlFilters.Controls.Add(this.btnSortPreparationTime);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(0, 165);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1902, 868);
            this.pnlFilters.TabIndex = 19;
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlLogo);
            this.Name = "FrmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStatistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
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
        private System.Windows.Forms.Button btnFilterThisMonth;
        private System.Windows.Forms.Button btnFilterThisWeek;
        private System.Windows.Forms.Button btnFilterToday;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.Button btnFilterAllTime;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnSortNbrOrders;
        private System.Windows.Forms.Button btnSortTotalRating;
        private System.Windows.Forms.Button btnSortPreparationTime;
        private System.Windows.Forms.Panel pnlFilters;
    }
}