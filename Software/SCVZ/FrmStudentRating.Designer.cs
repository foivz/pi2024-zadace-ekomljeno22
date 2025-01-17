namespace SCVZ
{
    partial class FrmStudentRating
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
            this.lblStudentRating = new System.Windows.Forms.Label();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rboUnsufficient = new System.Windows.Forms.RadioButton();
            this.rboSufficient = new System.Windows.Forms.RadioButton();
            this.rboGood = new System.Windows.Forms.RadioButton();
            this.rboVeryGood = new System.Windows.Forms.RadioButton();
            this.rboExcellent = new System.Windows.Forms.RadioButton();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlNav.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Controls.Add(this.lblStudentRating);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(512, 80);
            this.pnlNav.TabIndex = 35;
            // 
            // lblStudentRating
            // 
            this.lblStudentRating.AutoSize = true;
            this.lblStudentRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRating.ForeColor = System.Drawing.Color.White;
            this.lblStudentRating.Location = new System.Drawing.Point(174, 25);
            this.lblStudentRating.Name = "lblStudentRating";
            this.lblStudentRating.Size = new System.Drawing.Size(146, 36);
            this.lblStudentRating.TabIndex = 0;
            this.lblStudentRating.Text = "Recenzija";
            // 
            // btnAddRating
            // 
            this.btnAddRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRating.Location = new System.Drawing.Point(356, 444);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(144, 43);
            this.btnAddRating.TabIndex = 37;
            this.btnAddRating.Text = "Ocjeni";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 43);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rboUnsufficient
            // 
            this.rboUnsufficient.AutoSize = true;
            this.rboUnsufficient.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rboUnsufficient.Location = new System.Drawing.Point(9, 60);
            this.rboUnsufficient.Name = "rboUnsufficient";
            this.rboUnsufficient.Size = new System.Drawing.Size(81, 36);
            this.rboUnsufficient.TabIndex = 38;
            this.rboUnsufficient.TabStop = true;
            this.rboUnsufficient.Text = "Nedovoljan";
            this.rboUnsufficient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rboUnsufficient.UseVisualStyleBackColor = true;
            // 
            // rboSufficient
            // 
            this.rboSufficient.AutoSize = true;
            this.rboSufficient.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rboSufficient.Location = new System.Drawing.Point(96, 60);
            this.rboSufficient.Name = "rboSufficient";
            this.rboSufficient.Size = new System.Drawing.Size(65, 36);
            this.rboSufficient.TabIndex = 40;
            this.rboSufficient.TabStop = true;
            this.rboSufficient.Text = "Dovoljan";
            this.rboSufficient.UseVisualStyleBackColor = true;
            // 
            // rboGood
            // 
            this.rboGood.AutoSize = true;
            this.rboGood.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rboGood.Location = new System.Drawing.Point(179, 60);
            this.rboGood.Name = "rboGood";
            this.rboGood.Size = new System.Drawing.Size(49, 36);
            this.rboGood.TabIndex = 41;
            this.rboGood.TabStop = true;
            this.rboGood.Text = "Dobar";
            this.rboGood.UseVisualStyleBackColor = true;
            // 
            // rboVeryGood
            // 
            this.rboVeryGood.AutoSize = true;
            this.rboVeryGood.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rboVeryGood.Location = new System.Drawing.Point(243, 60);
            this.rboVeryGood.Name = "rboVeryGood";
            this.rboVeryGood.Size = new System.Drawing.Size(74, 36);
            this.rboVeryGood.TabIndex = 42;
            this.rboVeryGood.TabStop = true;
            this.rboVeryGood.Text = "Vrlo dobar";
            this.rboVeryGood.UseVisualStyleBackColor = true;
            // 
            // rboExcellent
            // 
            this.rboExcellent.AutoSize = true;
            this.rboExcellent.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rboExcellent.Location = new System.Drawing.Point(323, 60);
            this.rboExcellent.Name = "rboExcellent";
            this.rboExcellent.Size = new System.Drawing.Size(57, 36);
            this.rboExcellent.TabIndex = 43;
            this.rboExcellent.TabStop = true;
            this.rboExcellent.Text = "Odličan";
            this.rboExcellent.UseVisualStyleBackColor = true;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(51, 272);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(393, 154);
            this.txtComments.TabIndex = 46;
            this.txtComments.Text = "Dodatni komentari...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboVeryGood);
            this.groupBox1.Controls.Add(this.rboUnsufficient);
            this.groupBox1.Controls.Add(this.rboSufficient);
            this.groupBox1.Controls.Add(this.rboGood);
            this.groupBox1.Controls.Add(this.rboExcellent);
            this.groupBox1.Location = new System.Drawing.Point(51, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 150);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obrok je bio...";
            // 
            // FrmStudentRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(512, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmStudentRating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentRating";
            this.Load += new System.EventHandler(this.FrmStudentRating_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblStudentRating;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rboUnsufficient;
        private System.Windows.Forms.RadioButton rboSufficient;
        private System.Windows.Forms.RadioButton rboGood;
        private System.Windows.Forms.RadioButton rboVeryGood;
        private System.Windows.Forms.RadioButton rboExcellent;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}