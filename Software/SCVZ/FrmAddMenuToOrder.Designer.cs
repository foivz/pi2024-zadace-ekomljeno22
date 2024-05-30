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
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreview
            // 
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(12, 12);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.RowHeadersWidth = 51;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.Size = new System.Drawing.Size(668, 597);
            this.dgvPreview.TabIndex = 0;
            this.dgvPreview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellClick);
            this.dgvPreview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellDoubleClick);
            // 
            // dgvDetails
            // 
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(686, 12);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(481, 597);
            this.dgvDetails.TabIndex = 1;
            // 
            // FrmAddMenuToOrder
            // 
            this.ClientSize = new System.Drawing.Size(1179, 621);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.dgvPreview);
            this.Name = "FrmAddMenuToOrder";
            this.Text = "FrmAddMenuToOrder";
            this.Load += new System.EventHandler(this.FrmAddMenuToOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.DataGridView dgvDetails;
    }
}