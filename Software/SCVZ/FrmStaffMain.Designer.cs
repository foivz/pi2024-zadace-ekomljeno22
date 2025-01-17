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
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.pnlCurrentOrders = new System.Windows.Forms.Panel();
            this.gboNarudzba = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tboStatusNarudzbe = new System.Windows.Forms.TextBox();
            this.tboUkupniIznos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboIdNarudzbe = new System.Windows.Forms.TextBox();
            this.lblDatumNarudzbe = new System.Windows.Forms.Label();
            this.tboDatumNarudzbe = new System.Windows.Forms.TextBox();
            this.lblIdNarudzbe = new System.Windows.Forms.Label();
            this.gboMeni = new System.Windows.Forms.GroupBox();
            this.lboJela = new System.Windows.Forms.ListBox();
            this.lblVrijemePripreme = new System.Windows.Forms.Label();
            this.lblVrijednostPoklonBodova = new System.Windows.Forms.Label();
            this.lblVrstaMenija = new System.Windows.Forms.Label();
            this.lblCijenaMenija = new System.Windows.Forms.Label();
            this.tboVrijemePripreme = new System.Windows.Forms.TextBox();
            this.tboVrijednostPoklonBodova = new System.Windows.Forms.TextBox();
            this.tboVrstaMenija = new System.Windows.Forms.TextBox();
            this.tboCijenaMenija = new System.Windows.Forms.TextBox();
            this.gboStudent = new System.Windows.Forms.GroupBox();
            this.lblBrojKupona = new System.Windows.Forms.Label();
            this.lblBrojPoklonBodova = new System.Windows.Forms.Label();
            this.lblJMBAG = new System.Windows.Forms.Label();
            this.tboBrojKupona = new System.Windows.Forms.TextBox();
            this.tboBrojPoklonBodova = new System.Windows.Forms.TextBox();
            this.tboJMBAG = new System.Windows.Forms.TextBox();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tboUsername = new System.Windows.Forms.TextBox();
            this.tboPosition = new System.Windows.Forms.TextBox();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlCurrentOrders.SuspendLayout();
            this.gboNarudzba.SuspendLayout();
            this.gboMeni.SuspendLayout();
            this.gboStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pnlNav.TabIndex = 9;
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
            this.pnlLogo.TabIndex = 8;
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
            this.pnlFooter.TabIndex = 7;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.groupBox1);
            this.pnlSidebar.Controls.Add(this.btnPreview);
            this.pnlSidebar.Controls.Add(this.btnStatistics);
            this.pnlSidebar.Controls.Add(this.btnNewOrder);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 165);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(335, 777);
            this.pnlSidebar.TabIndex = 11;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(36, 225);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(197, 58);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Pregled";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Location = new System.Drawing.Point(36, 128);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(197, 58);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistika";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(36, 42);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(197, 58);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "Nova narudžba";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // pnlCurrentOrders
            // 
            this.pnlCurrentOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCurrentOrders.Controls.Add(this.gboNarudzba);
            this.pnlCurrentOrders.Controls.Add(this.gboMeni);
            this.pnlCurrentOrders.Controls.Add(this.gboStudent);
            this.pnlCurrentOrders.Controls.Add(this.dgvPreview);
            this.pnlCurrentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCurrentOrders.Location = new System.Drawing.Point(335, 165);
            this.pnlCurrentOrders.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCurrentOrders.Name = "pnlCurrentOrders";
            this.pnlCurrentOrders.Size = new System.Drawing.Size(1567, 777);
            this.pnlCurrentOrders.TabIndex = 12;
            // 
            // gboNarudzba
            // 
            this.gboNarudzba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboNarudzba.Controls.Add(this.lblStatus);
            this.gboNarudzba.Controls.Add(this.tboStatusNarudzbe);
            this.gboNarudzba.Controls.Add(this.tboUkupniIznos);
            this.gboNarudzba.Controls.Add(this.label2);
            this.gboNarudzba.Controls.Add(this.tboIdNarudzbe);
            this.gboNarudzba.Controls.Add(this.lblDatumNarudzbe);
            this.gboNarudzba.Controls.Add(this.tboDatumNarudzbe);
            this.gboNarudzba.Controls.Add(this.lblIdNarudzbe);
            this.gboNarudzba.Location = new System.Drawing.Point(874, 377);
            this.gboNarudzba.Name = "gboNarudzba";
            this.gboNarudzba.Size = new System.Drawing.Size(361, 374);
            this.gboNarudzba.TabIndex = 7;
            this.gboNarudzba.TabStop = false;
            this.gboNarudzba.Text = "Narudžba";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 133);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(106, 16);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status narudžbe:";
            // 
            // tboStatusNarudzbe
            // 
            this.tboStatusNarudzbe.Location = new System.Drawing.Point(189, 130);
            this.tboStatusNarudzbe.Name = "tboStatusNarudzbe";
            this.tboStatusNarudzbe.Size = new System.Drawing.Size(146, 22);
            this.tboStatusNarudzbe.TabIndex = 16;
            // 
            // tboUkupniIznos
            // 
            this.tboUkupniIznos.Location = new System.Drawing.Point(189, 99);
            this.tboUkupniIznos.Name = "tboUkupniIznos";
            this.tboUkupniIznos.Size = new System.Drawing.Size(146, 22);
            this.tboUkupniIznos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ukupni iznos kupona:";
            // 
            // tboIdNarudzbe
            // 
            this.tboIdNarudzbe.Location = new System.Drawing.Point(189, 41);
            this.tboIdNarudzbe.Name = "tboIdNarudzbe";
            this.tboIdNarudzbe.Size = new System.Drawing.Size(146, 22);
            this.tboIdNarudzbe.TabIndex = 8;
            // 
            // lblDatumNarudzbe
            // 
            this.lblDatumNarudzbe.AutoSize = true;
            this.lblDatumNarudzbe.Location = new System.Drawing.Point(17, 76);
            this.lblDatumNarudzbe.Name = "lblDatumNarudzbe";
            this.lblDatumNarudzbe.Size = new System.Drawing.Size(108, 16);
            this.lblDatumNarudzbe.TabIndex = 13;
            this.lblDatumNarudzbe.Text = "Datum narudžbe:";
            // 
            // tboDatumNarudzbe
            // 
            this.tboDatumNarudzbe.Location = new System.Drawing.Point(189, 69);
            this.tboDatumNarudzbe.Name = "tboDatumNarudzbe";
            this.tboDatumNarudzbe.Size = new System.Drawing.Size(146, 22);
            this.tboDatumNarudzbe.TabIndex = 9;
            // 
            // lblIdNarudzbe
            // 
            this.lblIdNarudzbe.AutoSize = true;
            this.lblIdNarudzbe.Location = new System.Drawing.Point(17, 47);
            this.lblIdNarudzbe.Name = "lblIdNarudzbe";
            this.lblIdNarudzbe.Size = new System.Drawing.Size(93, 16);
            this.lblIdNarudzbe.TabIndex = 12;
            this.lblIdNarudzbe.Text = "Broj narudžbe:";
            // 
            // gboMeni
            // 
            this.gboMeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboMeni.Controls.Add(this.lboJela);
            this.gboMeni.Controls.Add(this.lblVrijemePripreme);
            this.gboMeni.Controls.Add(this.lblVrijednostPoklonBodova);
            this.gboMeni.Controls.Add(this.lblVrstaMenija);
            this.gboMeni.Controls.Add(this.lblCijenaMenija);
            this.gboMeni.Controls.Add(this.tboVrijemePripreme);
            this.gboMeni.Controls.Add(this.tboVrijednostPoklonBodova);
            this.gboMeni.Controls.Add(this.tboVrstaMenija);
            this.gboMeni.Controls.Add(this.tboCijenaMenija);
            this.gboMeni.Location = new System.Drawing.Point(874, 6);
            this.gboMeni.Name = "gboMeni";
            this.gboMeni.Size = new System.Drawing.Size(361, 365);
            this.gboMeni.TabIndex = 6;
            this.gboMeni.TabStop = false;
            this.gboMeni.Text = "Meni";
            // 
            // lboJela
            // 
            this.lboJela.FormattingEnabled = true;
            this.lboJela.ItemHeight = 16;
            this.lboJela.Location = new System.Drawing.Point(20, 171);
            this.lboJela.Name = "lboJela";
            this.lboJela.Size = new System.Drawing.Size(315, 164);
            this.lboJela.TabIndex = 7;
            // 
            // lblVrijemePripreme
            // 
            this.lblVrijemePripreme.AutoSize = true;
            this.lblVrijemePripreme.Location = new System.Drawing.Point(17, 128);
            this.lblVrijemePripreme.Name = "lblVrijemePripreme";
            this.lblVrijemePripreme.Size = new System.Drawing.Size(113, 16);
            this.lblVrijemePripreme.TabIndex = 7;
            this.lblVrijemePripreme.Text = "Vrijeme pripreme:";
            // 
            // lblVrijednostPoklonBodova
            // 
            this.lblVrijednostPoklonBodova.AutoSize = true;
            this.lblVrijednostPoklonBodova.Location = new System.Drawing.Point(17, 100);
            this.lblVrijednostPoklonBodova.Name = "lblVrijednostPoklonBodova";
            this.lblVrijednostPoklonBodova.Size = new System.Drawing.Size(164, 16);
            this.lblVrijednostPoklonBodova.TabIndex = 6;
            this.lblVrijednostPoklonBodova.Text = "Vrijednost poklon bodova:";
            // 
            // lblVrstaMenija
            // 
            this.lblVrstaMenija.AutoSize = true;
            this.lblVrstaMenija.Location = new System.Drawing.Point(17, 71);
            this.lblVrstaMenija.Name = "lblVrstaMenija";
            this.lblVrstaMenija.Size = new System.Drawing.Size(84, 16);
            this.lblVrstaMenija.TabIndex = 5;
            this.lblVrstaMenija.Text = "Vrsta menija:";
            // 
            // lblCijenaMenija
            // 
            this.lblCijenaMenija.AutoSize = true;
            this.lblCijenaMenija.Location = new System.Drawing.Point(17, 42);
            this.lblCijenaMenija.Name = "lblCijenaMenija";
            this.lblCijenaMenija.Size = new System.Drawing.Size(91, 16);
            this.lblCijenaMenija.TabIndex = 4;
            this.lblCijenaMenija.Text = "Cijena menija:";
            // 
            // tboVrijemePripreme
            // 
            this.tboVrijemePripreme.Location = new System.Drawing.Point(189, 122);
            this.tboVrijemePripreme.Name = "tboVrijemePripreme";
            this.tboVrijemePripreme.Size = new System.Drawing.Size(146, 22);
            this.tboVrijemePripreme.TabIndex = 3;
            // 
            // tboVrijednostPoklonBodova
            // 
            this.tboVrijednostPoklonBodova.Location = new System.Drawing.Point(189, 94);
            this.tboVrijednostPoklonBodova.Name = "tboVrijednostPoklonBodova";
            this.tboVrijednostPoklonBodova.Size = new System.Drawing.Size(146, 22);
            this.tboVrijednostPoklonBodova.TabIndex = 2;
            // 
            // tboVrstaMenija
            // 
            this.tboVrstaMenija.Location = new System.Drawing.Point(189, 64);
            this.tboVrstaMenija.Name = "tboVrstaMenija";
            this.tboVrstaMenija.Size = new System.Drawing.Size(146, 22);
            this.tboVrstaMenija.TabIndex = 1;
            // 
            // tboCijenaMenija
            // 
            this.tboCijenaMenija.Location = new System.Drawing.Point(189, 36);
            this.tboCijenaMenija.Name = "tboCijenaMenija";
            this.tboCijenaMenija.Size = new System.Drawing.Size(146, 22);
            this.tboCijenaMenija.TabIndex = 0;
            // 
            // gboStudent
            // 
            this.gboStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboStudent.Controls.Add(this.lblBrojKupona);
            this.gboStudent.Controls.Add(this.lblBrojPoklonBodova);
            this.gboStudent.Controls.Add(this.lblJMBAG);
            this.gboStudent.Controls.Add(this.tboBrojKupona);
            this.gboStudent.Controls.Add(this.tboBrojPoklonBodova);
            this.gboStudent.Controls.Add(this.tboJMBAG);
            this.gboStudent.Location = new System.Drawing.Point(1241, 6);
            this.gboStudent.Name = "gboStudent";
            this.gboStudent.Size = new System.Drawing.Size(312, 164);
            this.gboStudent.TabIndex = 5;
            this.gboStudent.TabStop = false;
            this.gboStudent.Text = "Student";
            // 
            // lblBrojKupona
            // 
            this.lblBrojKupona.AutoSize = true;
            this.lblBrojKupona.Location = new System.Drawing.Point(24, 100);
            this.lblBrojKupona.Name = "lblBrojKupona";
            this.lblBrojKupona.Size = new System.Drawing.Size(82, 16);
            this.lblBrojKupona.TabIndex = 7;
            this.lblBrojKupona.Text = "Broj kupona:";
            // 
            // lblBrojPoklonBodova
            // 
            this.lblBrojPoklonBodova.AutoSize = true;
            this.lblBrojPoklonBodova.Location = new System.Drawing.Point(24, 71);
            this.lblBrojPoklonBodova.Name = "lblBrojPoklonBodova";
            this.lblBrojPoklonBodova.Size = new System.Drawing.Size(128, 16);
            this.lblBrojPoklonBodova.TabIndex = 6;
            this.lblBrojPoklonBodova.Text = "Broj poklon bodova:";
            // 
            // lblJMBAG
            // 
            this.lblJMBAG.AutoSize = true;
            this.lblJMBAG.Location = new System.Drawing.Point(24, 42);
            this.lblJMBAG.Name = "lblJMBAG";
            this.lblJMBAG.Size = new System.Drawing.Size(56, 16);
            this.lblJMBAG.TabIndex = 5;
            this.lblJMBAG.Text = "JMBAG:";
            // 
            // tboBrojKupona
            // 
            this.tboBrojKupona.Location = new System.Drawing.Point(160, 94);
            this.tboBrojKupona.Name = "tboBrojKupona";
            this.tboBrojKupona.Size = new System.Drawing.Size(131, 22);
            this.tboBrojKupona.TabIndex = 3;
            // 
            // tboBrojPoklonBodova
            // 
            this.tboBrojPoklonBodova.Location = new System.Drawing.Point(160, 65);
            this.tboBrojPoklonBodova.Name = "tboBrojPoklonBodova";
            this.tboBrojPoklonBodova.Size = new System.Drawing.Size(131, 22);
            this.tboBrojPoklonBodova.TabIndex = 2;
            // 
            // tboJMBAG
            // 
            this.tboJMBAG.Location = new System.Drawing.Point(160, 36);
            this.tboJMBAG.Name = "tboJMBAG";
            this.tboJMBAG.Size = new System.Drawing.Size(131, 22);
            this.tboJMBAG.TabIndex = 1;
            // 
            // dgvPreview
            // 
            this.dgvPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(4, 6);
            this.dgvPreview.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.RowHeadersWidth = 51;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.Size = new System.Drawing.Size(865, 766);
            this.dgvPreview.TabIndex = 0;
            this.dgvPreview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellClick);
            this.dgvPreview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tboPosition);
            this.groupBox1.Controls.Add(this.tboUsername);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 604);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaposlenik";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(17, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 18);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(17, 102);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(64, 18);
            this.lblPosition.TabIndex = 19;
            this.lblPosition.Text = "Pozicija:";
            // 
            // tboUsername
            // 
            this.tboUsername.Location = new System.Drawing.Point(134, 51);
            this.tboUsername.Name = "tboUsername";
            this.tboUsername.Size = new System.Drawing.Size(146, 24);
            this.tboUsername.TabIndex = 18;
            // 
            // tboPosition
            // 
            this.tboPosition.Location = new System.Drawing.Point(134, 99);
            this.tboPosition.Name = "tboPosition";
            this.tboPosition.Size = new System.Drawing.Size(146, 24);
            this.tboPosition.TabIndex = 20;
            // 
            // FrmStaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1902, 1032);
            this.Controls.Add(this.pnlCurrentOrders);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlFooter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStaffMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStaffMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStaffMain_Load);
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlCurrentOrders.ResumeLayout(false);
            this.gboNarudzba.ResumeLayout(false);
            this.gboNarudzba.PerformLayout();
            this.gboMeni.ResumeLayout(false);
            this.gboMeni.PerformLayout();
            this.gboStudent.ResumeLayout(false);
            this.gboStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.GroupBox gboStudent;
        private System.Windows.Forms.TextBox tboJMBAG;
        private System.Windows.Forms.TextBox tboBrojKupona;
        private System.Windows.Forms.TextBox tboBrojPoklonBodova;
        private System.Windows.Forms.Label lblBrojKupona;
        private System.Windows.Forms.Label lblBrojPoklonBodova;
        private System.Windows.Forms.Label lblJMBAG;
        private System.Windows.Forms.GroupBox gboMeni;
        private System.Windows.Forms.TextBox tboVrstaMenija;
        private System.Windows.Forms.TextBox tboCijenaMenija;
        private System.Windows.Forms.TextBox tboVrijednostPoklonBodova;
        private System.Windows.Forms.TextBox tboVrijemePripreme;
        private System.Windows.Forms.Label lblVrijemePripreme;
        private System.Windows.Forms.Label lblVrijednostPoklonBodova;
        private System.Windows.Forms.Label lblVrstaMenija;
        private System.Windows.Forms.Label lblCijenaMenija;
        private System.Windows.Forms.ListBox lboJela;
        private System.Windows.Forms.GroupBox gboNarudzba;
        private System.Windows.Forms.TextBox tboUkupniIznos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboIdNarudzbe;
        private System.Windows.Forms.Label lblDatumNarudzbe;
        private System.Windows.Forms.TextBox tboDatumNarudzbe;
        private System.Windows.Forms.Label lblIdNarudzbe;
        private System.Windows.Forms.TextBox tboStatusNarudzbe;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tboPosition;
        private System.Windows.Forms.TextBox tboUsername;
    }
}