namespace SCVZ
{
    partial class FrmAddMenuToOrder
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
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.gboJela = new System.Windows.Forms.GroupBox();
            this.lboJela = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.gboJela.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPreview
            // 
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(12, 12);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.RowHeadersWidth = 51;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.Size = new System.Drawing.Size(508, 286);
            this.dgvPreview.TabIndex = 0;
            this.dgvPreview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellClick);
            this.dgvPreview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellDoubleClick);
            // 
            // gboJela
            // 
            this.gboJela.Controls.Add(this.lboJela);
            this.gboJela.Location = new System.Drawing.Point(526, 12);
            this.gboJela.Name = "gboJela";
            this.gboJela.Size = new System.Drawing.Size(410, 201);
            this.gboJela.TabIndex = 1;
            this.gboJela.TabStop = false;
            this.gboJela.Text = "Jela";
            // 
            // lboJela
            // 
            this.lboJela.FormattingEnabled = true;
            this.lboJela.ItemHeight = 16;
            this.lboJela.Location = new System.Drawing.Point(6, 62);
            this.lboJela.Name = "lboJela";
            this.lboJela.Size = new System.Drawing.Size(398, 132);
            this.lboJela.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(777, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 41);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddMenuToOrder
            // 
            this.ClientSize = new System.Drawing.Size(950, 307);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gboJela);
            this.Controls.Add(this.dgvPreview);
            this.Name = "FrmAddMenuToOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddMenuToOrder";
            this.Load += new System.EventHandler(this.FrmAddMenuToOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.gboJela.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.GroupBox gboJela;
        private System.Windows.Forms.ListBox lboJela;
        private System.Windows.Forms.Button btnCancel;
    }
}