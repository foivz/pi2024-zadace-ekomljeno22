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
            this.lblSort = new System.Windows.Forms.Label();
            this.btnSortOrderNbr = new System.Windows.Forms.Button();
            this.btnSortTotalRating = new System.Windows.Forms.Button();
            this.btnSortPreparationTime = new System.Windows.Forms.Button();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.gboStatistika = new System.Windows.Forms.GroupBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.gboMeni = new System.Windows.Forms.GroupBox();
            this.gboJela = new System.Windows.Forms.GroupBox();
            this.lboJela = new System.Windows.Forms.ListBox();
            this.tboVrstaMenija = new System.Windows.Forms.TextBox();
            this.lblVrstaMenija = new System.Windows.Forms.Label();
            this.tboVrijemePripreme = new System.Windows.Forms.TextBox();
            this.lblVrijemePripreme = new System.Windows.Forms.Label();
            this.tboBrojPoklonBodova = new System.Windows.Forms.TextBox();
            this.lblBrojPoklonBodova = new System.Windows.Forms.Label();
            this.tboCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.tboMeniId = new System.Windows.Forms.TextBox();
            this.lblMeniId = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvRatings = new System.Windows.Forms.DataGridView();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.gboStatistika.SuspendLayout();
            this.gboMeni.SuspendLayout();
            this.gboJela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
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
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(45, 21);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(120, 20);
            this.lblSort.TabIndex = 0;
            this.lblSort.Text = "Sortiraj prema:";
            // 
            // btnSortOrderNbr
            // 
            this.btnSortOrderNbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortOrderNbr.Location = new System.Drawing.Point(192, 15);
            this.btnSortOrderNbr.Name = "btnSortOrderNbr";
            this.btnSortOrderNbr.Size = new System.Drawing.Size(157, 33);
            this.btnSortOrderNbr.TabIndex = 0;
            this.btnSortOrderNbr.Text = "broju narudžbi";
            this.btnSortOrderNbr.UseVisualStyleBackColor = true;
            this.btnSortOrderNbr.Click += new System.EventHandler(this.btnSortOrderNbr_Click);
            // 
            // btnSortTotalRating
            // 
            this.btnSortTotalRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortTotalRating.Location = new System.Drawing.Point(370, 15);
            this.btnSortTotalRating.Name = "btnSortTotalRating";
            this.btnSortTotalRating.Size = new System.Drawing.Size(157, 33);
            this.btnSortTotalRating.TabIndex = 1;
            this.btnSortTotalRating.Text = "ukupnoj ocjeni";
            this.btnSortTotalRating.UseVisualStyleBackColor = true;
            this.btnSortTotalRating.Click += new System.EventHandler(this.btnSortTotalRating_Click);
            // 
            // btnSortPreparationTime
            // 
            this.btnSortPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortPreparationTime.Location = new System.Drawing.Point(547, 15);
            this.btnSortPreparationTime.Name = "btnSortPreparationTime";
            this.btnSortPreparationTime.Size = new System.Drawing.Size(157, 33);
            this.btnSortPreparationTime.TabIndex = 3;
            this.btnSortPreparationTime.Text = "vremenu pripreme";
            this.btnSortPreparationTime.UseVisualStyleBackColor = true;
            this.btnSortPreparationTime.Click += new System.EventHandler(this.btnSortPreparationTime_Click);
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.gboStatistika);
            this.pnlFilters.Controls.Add(this.gboMeni);
            this.pnlFilters.Controls.Add(this.btnReset);
            this.pnlFilters.Controls.Add(this.dgvRatings);
            this.pnlFilters.Controls.Add(this.dgvPreview);
            this.pnlFilters.Controls.Add(this.btnSortTotalRating);
            this.pnlFilters.Controls.Add(this.btnSortOrderNbr);
            this.pnlFilters.Controls.Add(this.lblSort);
            this.pnlFilters.Controls.Add(this.btnSortPreparationTime);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(0, 165);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1902, 868);
            this.pnlFilters.TabIndex = 19;
            // 
            // gboStatistika
            // 
            this.gboStatistika.Controls.Add(this.lblAverage);
            this.gboStatistika.Controls.Add(this.txtAvg);
            this.gboStatistika.Controls.Add(this.txtCount);
            this.gboStatistika.Controls.Add(this.lblCount);
            this.gboStatistika.Location = new System.Drawing.Point(542, 496);
            this.gboStatistika.Name = "gboStatistika";
            this.gboStatistika.Size = new System.Drawing.Size(395, 115);
            this.gboStatistika.TabIndex = 17;
            this.gboStatistika.TabStop = false;
            this.gboStatistika.Text = "Statistika";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(6, 26);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(249, 18);
            this.lblAverage.TabIndex = 14;
            this.lblAverage.Text = "Prosječna ocjena odabranog menija:";
            // 
            // txtAvg
            // 
            this.txtAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvg.Location = new System.Drawing.Point(301, 14);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(68, 28);
            this.txtAvg.TabIndex = 9;
            this.txtAvg.TextChanged += new System.EventHandler(this.txtAvg_TextChanged);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(301, 51);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(68, 28);
            this.txtCount.TabIndex = 12;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(6, 59);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(154, 18);
            this.lblCount.TabIndex = 15;
            this.lblCount.Text = "Broj naručenih menija:";
            // 
            // gboMeni
            // 
            this.gboMeni.Controls.Add(this.gboJela);
            this.gboMeni.Controls.Add(this.tboVrstaMenija);
            this.gboMeni.Controls.Add(this.lblVrstaMenija);
            this.gboMeni.Controls.Add(this.tboVrijemePripreme);
            this.gboMeni.Controls.Add(this.lblVrijemePripreme);
            this.gboMeni.Controls.Add(this.tboBrojPoklonBodova);
            this.gboMeni.Controls.Add(this.lblBrojPoklonBodova);
            this.gboMeni.Controls.Add(this.tboCijena);
            this.gboMeni.Controls.Add(this.lblCijena);
            this.gboMeni.Controls.Add(this.tboMeniId);
            this.gboMeni.Controls.Add(this.lblMeniId);
            this.gboMeni.Location = new System.Drawing.Point(542, 67);
            this.gboMeni.Name = "gboMeni";
            this.gboMeni.Size = new System.Drawing.Size(395, 412);
            this.gboMeni.TabIndex = 16;
            this.gboMeni.TabStop = false;
            this.gboMeni.Text = "Meni";
            // 
            // gboJela
            // 
            this.gboJela.Controls.Add(this.lboJela);
            this.gboJela.Location = new System.Drawing.Point(11, 186);
            this.gboJela.Name = "gboJela";
            this.gboJela.Size = new System.Drawing.Size(378, 216);
            this.gboJela.TabIndex = 10;
            this.gboJela.TabStop = false;
            this.gboJela.Text = "Jela";
            // 
            // lboJela
            // 
            this.lboJela.FormattingEnabled = true;
            this.lboJela.ItemHeight = 16;
            this.lboJela.Location = new System.Drawing.Point(7, 46);
            this.lboJela.Name = "lboJela";
            this.lboJela.Size = new System.Drawing.Size(365, 164);
            this.lboJela.TabIndex = 0;
            // 
            // tboVrstaMenija
            // 
            this.tboVrstaMenija.Location = new System.Drawing.Point(150, 140);
            this.tboVrstaMenija.Name = "tboVrstaMenija";
            this.tboVrstaMenija.Size = new System.Drawing.Size(233, 22);
            this.tboVrstaMenija.TabIndex = 9;
            // 
            // lblVrstaMenija
            // 
            this.lblVrstaMenija.AutoSize = true;
            this.lblVrstaMenija.Location = new System.Drawing.Point(7, 146);
            this.lblVrstaMenija.Name = "lblVrstaMenija";
            this.lblVrstaMenija.Size = new System.Drawing.Size(84, 16);
            this.lblVrstaMenija.TabIndex = 8;
            this.lblVrstaMenija.Text = "Vrsta menija:";
            // 
            // tboVrijemePripreme
            // 
            this.tboVrijemePripreme.Location = new System.Drawing.Point(150, 112);
            this.tboVrijemePripreme.Name = "tboVrijemePripreme";
            this.tboVrijemePripreme.Size = new System.Drawing.Size(233, 22);
            this.tboVrijemePripreme.TabIndex = 7;
            // 
            // lblVrijemePripreme
            // 
            this.lblVrijemePripreme.AutoSize = true;
            this.lblVrijemePripreme.Location = new System.Drawing.Point(7, 118);
            this.lblVrijemePripreme.Name = "lblVrijemePripreme";
            this.lblVrijemePripreme.Size = new System.Drawing.Size(113, 16);
            this.lblVrijemePripreme.TabIndex = 6;
            this.lblVrijemePripreme.Text = "Vrijeme pripreme:";
            // 
            // tboBrojPoklonBodova
            // 
            this.tboBrojPoklonBodova.Location = new System.Drawing.Point(150, 84);
            this.tboBrojPoklonBodova.Name = "tboBrojPoklonBodova";
            this.tboBrojPoklonBodova.Size = new System.Drawing.Size(233, 22);
            this.tboBrojPoklonBodova.TabIndex = 5;
            // 
            // lblBrojPoklonBodova
            // 
            this.lblBrojPoklonBodova.AutoSize = true;
            this.lblBrojPoklonBodova.Location = new System.Drawing.Point(7, 90);
            this.lblBrojPoklonBodova.Name = "lblBrojPoklonBodova";
            this.lblBrojPoklonBodova.Size = new System.Drawing.Size(128, 16);
            this.lblBrojPoklonBodova.TabIndex = 4;
            this.lblBrojPoklonBodova.Text = "Broj poklon bodova:";
            // 
            // tboCijena
            // 
            this.tboCijena.Location = new System.Drawing.Point(150, 56);
            this.tboCijena.Name = "tboCijena";
            this.tboCijena.Size = new System.Drawing.Size(233, 22);
            this.tboCijena.TabIndex = 3;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(7, 62);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(48, 16);
            this.lblCijena.TabIndex = 2;
            this.lblCijena.Text = "Cijena:";
            // 
            // tboMeniId
            // 
            this.tboMeniId.Location = new System.Drawing.Point(150, 28);
            this.tboMeniId.Name = "tboMeniId";
            this.tboMeniId.Size = new System.Drawing.Size(233, 22);
            this.tboMeniId.TabIndex = 1;
            // 
            // lblMeniId
            // 
            this.lblMeniId.AutoSize = true;
            this.lblMeniId.Location = new System.Drawing.Point(7, 34);
            this.lblMeniId.Name = "lblMeniId";
            this.lblMeniId.Size = new System.Drawing.Size(77, 16);
            this.lblMeniId.TabIndex = 0;
            this.lblMeniId.Text = "Broj menija:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(542, 617);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 40);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Očisti";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvRatings
            // 
            this.dgvRatings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRatings.Location = new System.Drawing.Point(943, 67);
            this.dgvRatings.Name = "dgvRatings";
            this.dgvRatings.RowHeadersWidth = 51;
            this.dgvRatings.RowTemplate.Height = 24;
            this.dgvRatings.Size = new System.Drawing.Size(956, 705);
            this.dgvRatings.TabIndex = 7;
            // 
            // dgvPreview
            // 
            this.dgvPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(8, 67);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.RowHeadersWidth = 51;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.Size = new System.Drawing.Size(528, 705);
            this.dgvPreview.TabIndex = 5;
            this.dgvPreview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellClick);
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlLogo);
            this.Name = "FrmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStatistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStatistics_Load);
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.gboStatistika.ResumeLayout(false);
            this.gboStatistika.PerformLayout();
            this.gboMeni.ResumeLayout(false);
            this.gboMeni.PerformLayout();
            this.gboJela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox imgHome;
        private System.Windows.Forms.PictureBox imgBack;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnSortOrderNbr;
        private System.Windows.Forms.Button btnSortTotalRating;
        private System.Windows.Forms.Button btnSortPreparationTime;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.DataGridView dgvRatings;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.GroupBox gboMeni;
        private System.Windows.Forms.TextBox tboVrijemePripreme;
        private System.Windows.Forms.Label lblVrijemePripreme;
        private System.Windows.Forms.TextBox tboBrojPoklonBodova;
        private System.Windows.Forms.Label lblBrojPoklonBodova;
        private System.Windows.Forms.TextBox tboCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox tboMeniId;
        private System.Windows.Forms.Label lblMeniId;
        private System.Windows.Forms.TextBox tboVrstaMenija;
        private System.Windows.Forms.Label lblVrstaMenija;
        private System.Windows.Forms.GroupBox gboJela;
        private System.Windows.Forms.ListBox lboJela;
        private System.Windows.Forms.GroupBox gboStatistika;
    }
}