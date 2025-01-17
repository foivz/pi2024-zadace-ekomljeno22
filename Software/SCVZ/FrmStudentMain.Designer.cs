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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.imgBack = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.dgvStudentOrders = new System.Windows.Forms.DataGridView();
            this.gboDetails = new System.Windows.Forms.GroupBox();
            this.lboJela = new System.Windows.Forms.ListBox();
            this.btnOrderStudent = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gboStudent = new System.Windows.Forms.GroupBox();
            this.tboKuponi = new System.Windows.Forms.TextBox();
            this.lblKuponi = new System.Windows.Forms.Label();
            this.tboPoklonBodovi = new System.Windows.Forms.TextBox();
            this.lblPoklonBodovi = new System.Windows.Forms.Label();
            this.tboJMBAG = new System.Windows.Forms.TextBox();
            this.lblJMBAG = new System.Windows.Forms.Label();
            this.tboPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.tboIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.gboNarudzba = new System.Windows.Forms.GroupBox();
            this.tboUkupniIznos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboIdNarudzbe = new System.Windows.Forms.TextBox();
            this.lblDatumNarudzbe = new System.Windows.Forms.Label();
            this.tboDatumNarudzbe = new System.Windows.Forms.TextBox();
            this.lblIdNarudzbe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentOrders)).BeginInit();
            this.gboDetails.SuspendLayout();
            this.gboStudent.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.gboNarudzba.SuspendLayout();
            this.SuspendLayout();
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
            // dgvPreview
            // 
            this.dgvPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(401, 171);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.RowHeadersWidth = 51;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.Size = new System.Drawing.Size(610, 766);
            this.dgvPreview.TabIndex = 13;
            this.dgvPreview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellClick);
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
            this.pnlNav.TabIndex = 16;
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
            this.pnlLogo.TabIndex = 15;
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
            // dgvStudentOrders
            // 
            this.dgvStudentOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentOrders.Location = new System.Drawing.Point(1375, 171);
            this.dgvStudentOrders.Name = "dgvStudentOrders";
            this.dgvStudentOrders.RowHeadersWidth = 51;
            this.dgvStudentOrders.RowTemplate.Height = 24;
            this.dgvStudentOrders.Size = new System.Drawing.Size(515, 766);
            this.dgvStudentOrders.TabIndex = 0;
            this.dgvStudentOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentOrders_CellClick);
            // 
            // gboDetails
            // 
            this.gboDetails.Controls.Add(this.lboJela);
            this.gboDetails.Location = new System.Drawing.Point(1033, 383);
            this.gboDetails.Name = "gboDetails";
            this.gboDetails.Size = new System.Drawing.Size(320, 211);
            this.gboDetails.TabIndex = 17;
            this.gboDetails.TabStop = false;
            this.gboDetails.Text = "Jela";
            // 
            // lboJela
            // 
            this.lboJela.FormattingEnabled = true;
            this.lboJela.ItemHeight = 16;
            this.lboJela.Location = new System.Drawing.Point(6, 53);
            this.lboJela.Name = "lboJela";
            this.lboJela.Size = new System.Drawing.Size(308, 148);
            this.lboJela.TabIndex = 0;
            // 
            // btnOrderStudent
            // 
            this.btnOrderStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderStudent.BackColor = System.Drawing.Color.White;
            this.btnOrderStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderStudent.Location = new System.Drawing.Point(13, 281);
            this.btnOrderStudent.Name = "btnOrderStudent";
            this.btnOrderStudent.Size = new System.Drawing.Size(168, 42);
            this.btnOrderStudent.TabIndex = 1;
            this.btnOrderStudent.Text = "Nova narudžba";
            this.btnOrderStudent.UseVisualStyleBackColor = false;
            this.btnOrderStudent.Click += new System.EventHandler(this.btnOrderStudent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(13, 345);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 42);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Osvježi";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gboStudent
            // 
            this.gboStudent.Controls.Add(this.tboKuponi);
            this.gboStudent.Controls.Add(this.lblKuponi);
            this.gboStudent.Controls.Add(this.tboPoklonBodovi);
            this.gboStudent.Controls.Add(this.lblPoklonBodovi);
            this.gboStudent.Controls.Add(this.tboJMBAG);
            this.gboStudent.Controls.Add(this.lblJMBAG);
            this.gboStudent.Controls.Add(this.tboPrezime);
            this.gboStudent.Controls.Add(this.lblPrezime);
            this.gboStudent.Controls.Add(this.tboIme);
            this.gboStudent.Controls.Add(this.lblIme);
            this.gboStudent.Location = new System.Drawing.Point(13, 12);
            this.gboStudent.Name = "gboStudent";
            this.gboStudent.Size = new System.Drawing.Size(287, 257);
            this.gboStudent.TabIndex = 4;
            this.gboStudent.TabStop = false;
            this.gboStudent.Text = "Student";
            // 
            // tboKuponi
            // 
            this.tboKuponi.Location = new System.Drawing.Point(132, 205);
            this.tboKuponi.Name = "tboKuponi";
            this.tboKuponi.Size = new System.Drawing.Size(100, 22);
            this.tboKuponi.TabIndex = 9;
            // 
            // lblKuponi
            // 
            this.lblKuponi.AutoSize = true;
            this.lblKuponi.Location = new System.Drawing.Point(23, 208);
            this.lblKuponi.Name = "lblKuponi";
            this.lblKuponi.Size = new System.Drawing.Size(51, 16);
            this.lblKuponi.TabIndex = 8;
            this.lblKuponi.Text = "Kuponi:";
            // 
            // tboPoklonBodovi
            // 
            this.tboPoklonBodovi.Location = new System.Drawing.Point(132, 166);
            this.tboPoklonBodovi.Name = "tboPoklonBodovi";
            this.tboPoklonBodovi.Size = new System.Drawing.Size(100, 22);
            this.tboPoklonBodovi.TabIndex = 7;
            // 
            // lblPoklonBodovi
            // 
            this.lblPoklonBodovi.AutoSize = true;
            this.lblPoklonBodovi.Location = new System.Drawing.Point(23, 169);
            this.lblPoklonBodovi.Name = "lblPoklonBodovi";
            this.lblPoklonBodovi.Size = new System.Drawing.Size(97, 16);
            this.lblPoklonBodovi.TabIndex = 6;
            this.lblPoklonBodovi.Text = "Poklon bodovi:";
            // 
            // tboJMBAG
            // 
            this.tboJMBAG.Location = new System.Drawing.Point(132, 123);
            this.tboJMBAG.Name = "tboJMBAG";
            this.tboJMBAG.Size = new System.Drawing.Size(100, 22);
            this.tboJMBAG.TabIndex = 5;
            // 
            // lblJMBAG
            // 
            this.lblJMBAG.AutoSize = true;
            this.lblJMBAG.Location = new System.Drawing.Point(23, 126);
            this.lblJMBAG.Name = "lblJMBAG";
            this.lblJMBAG.Size = new System.Drawing.Size(56, 16);
            this.lblJMBAG.TabIndex = 4;
            this.lblJMBAG.Text = "JMBAG:";
            // 
            // tboPrezime
            // 
            this.tboPrezime.Location = new System.Drawing.Point(132, 80);
            this.tboPrezime.Name = "tboPrezime";
            this.tboPrezime.Size = new System.Drawing.Size(100, 22);
            this.tboPrezime.TabIndex = 3;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(23, 83);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // tboIme
            // 
            this.tboIme.Location = new System.Drawing.Point(132, 38);
            this.tboIme.Name = "tboIme";
            this.tboIme.Size = new System.Drawing.Size(100, 22);
            this.tboIme.TabIndex = 1;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(23, 41);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.gboStudent);
            this.pnlSidebar.Controls.Add(this.btnRefresh);
            this.pnlSidebar.Controls.Add(this.btnOrderStudent);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 159);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 721);
            this.pnlSidebar.TabIndex = 10;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);
            // 
            // gboNarudzba
            // 
            this.gboNarudzba.Controls.Add(this.tboUkupniIznos);
            this.gboNarudzba.Controls.Add(this.label2);
            this.gboNarudzba.Controls.Add(this.tboIdNarudzbe);
            this.gboNarudzba.Controls.Add(this.lblDatumNarudzbe);
            this.gboNarudzba.Controls.Add(this.tboDatumNarudzbe);
            this.gboNarudzba.Controls.Add(this.lblIdNarudzbe);
            this.gboNarudzba.Location = new System.Drawing.Point(1033, 171);
            this.gboNarudzba.Name = "gboNarudzba";
            this.gboNarudzba.Size = new System.Drawing.Size(320, 186);
            this.gboNarudzba.TabIndex = 18;
            this.gboNarudzba.TabStop = false;
            this.gboNarudzba.Text = "Narudžba";
            // 
            // tboUkupniIznos
            // 
            this.tboUkupniIznos.Location = new System.Drawing.Point(156, 111);
            this.tboUkupniIznos.Name = "tboUkupniIznos";
            this.tboUkupniIznos.Size = new System.Drawing.Size(146, 22);
            this.tboUkupniIznos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ukupni iznos kupona:";
            // 
            // tboIdNarudzbe
            // 
            this.tboIdNarudzbe.Location = new System.Drawing.Point(156, 53);
            this.tboIdNarudzbe.Name = "tboIdNarudzbe";
            this.tboIdNarudzbe.Size = new System.Drawing.Size(146, 22);
            this.tboIdNarudzbe.TabIndex = 15;
            // 
            // lblDatumNarudzbe
            // 
            this.lblDatumNarudzbe.AutoSize = true;
            this.lblDatumNarudzbe.Location = new System.Drawing.Point(16, 88);
            this.lblDatumNarudzbe.Name = "lblDatumNarudzbe";
            this.lblDatumNarudzbe.Size = new System.Drawing.Size(108, 16);
            this.lblDatumNarudzbe.TabIndex = 19;
            this.lblDatumNarudzbe.Text = "Datum narudžbe:";
            // 
            // tboDatumNarudzbe
            // 
            this.tboDatumNarudzbe.Location = new System.Drawing.Point(156, 81);
            this.tboDatumNarudzbe.Name = "tboDatumNarudzbe";
            this.tboDatumNarudzbe.Size = new System.Drawing.Size(146, 22);
            this.tboDatumNarudzbe.TabIndex = 16;
            // 
            // lblIdNarudzbe
            // 
            this.lblIdNarudzbe.AutoSize = true;
            this.lblIdNarudzbe.Location = new System.Drawing.Point(16, 59);
            this.lblIdNarudzbe.Name = "lblIdNarudzbe";
            this.lblIdNarudzbe.Size = new System.Drawing.Size(93, 16);
            this.lblIdNarudzbe.TabIndex = 18;
            this.lblIdNarudzbe.Text = "Broj narudžbe:";
            // 
            // FrmStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.gboNarudzba);
            this.Controls.Add(this.dgvStudentOrders);
            this.Controls.Add(this.gboDetails);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.dgvPreview);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlFooter);
            this.Name = "FrmStudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStudentMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentOrders)).EndInit();
            this.gboDetails.ResumeLayout(false);
            this.gboStudent.ResumeLayout(false);
            this.gboStudent.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.gboNarudzba.ResumeLayout(false);
            this.gboNarudzba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox imgHome;
        private System.Windows.Forms.PictureBox imgBack;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.DataGridView dgvStudentOrders;
        private System.Windows.Forms.GroupBox gboDetails;
        private System.Windows.Forms.ListBox lboJela;
        private System.Windows.Forms.Button btnOrderStudent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gboStudent;
        private System.Windows.Forms.TextBox tboKuponi;
        private System.Windows.Forms.Label lblKuponi;
        private System.Windows.Forms.TextBox tboPoklonBodovi;
        private System.Windows.Forms.Label lblPoklonBodovi;
        private System.Windows.Forms.TextBox tboJMBAG;
        private System.Windows.Forms.Label lblJMBAG;
        private System.Windows.Forms.TextBox tboPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox tboIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.GroupBox gboNarudzba;
        private System.Windows.Forms.TextBox tboUkupniIznos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboIdNarudzbe;
        private System.Windows.Forms.Label lblDatumNarudzbe;
        private System.Windows.Forms.TextBox tboDatumNarudzbe;
        private System.Windows.Forms.Label lblIdNarudzbe;
    }
}