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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestion02 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.pnlNav.SuspendLayout();
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
            this.btnAddRating.Location = new System.Drawing.Point(356, 504);
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
            this.btnCancel.Location = new System.Drawing.Point(12, 503);
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
            this.rboUnsufficient.Location = new System.Drawing.Point(63, 213);
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
            this.rboSufficient.Location = new System.Drawing.Point(150, 213);
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
            this.rboGood.Location = new System.Drawing.Point(233, 213);
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
            this.rboVeryGood.Location = new System.Drawing.Point(297, 213);
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
            this.rboExcellent.Location = new System.Drawing.Point(377, 213);
            this.rboExcellent.Name = "rboExcellent";
            this.rboExcellent.Size = new System.Drawing.Size(57, 36);
            this.rboExcellent.TabIndex = 43;
            this.rboExcellent.TabStop = true;
            this.rboExcellent.Text = "Odličan";
            this.rboExcellent.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(47, 106);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(246, 20);
            this.lblQuestion.TabIndex = 44;
            this.lblQuestion.Text = "Kako Vam se svidio ovaj obrok?";
            // 
            // lblQuestion02
            // 
            this.lblQuestion02.AutoSize = true;
            this.lblQuestion02.Location = new System.Drawing.Point(48, 172);
            this.lblQuestion02.Name = "lblQuestion02";
            this.lblQuestion02.Size = new System.Drawing.Size(89, 16);
            this.lblQuestion02.TabIndex = 45;
            this.lblQuestion02.Text = "Obrok je bio...";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(51, 300);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(393, 154);
            this.txtComments.TabIndex = 46;
            this.txtComments.Text = "Dodatni komentari...";
            // 
            // FrmStudentRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblQuestion02);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.rboExcellent);
            this.Controls.Add(this.rboVeryGood);
            this.Controls.Add(this.rboGood);
            this.Controls.Add(this.rboSufficient);
            this.Controls.Add(this.rboUnsufficient);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmStudentRating";
            this.Text = "FrmStudentRating";
            this.Load += new System.EventHandler(this.FrmStudentRating_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
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
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestion02;
        private System.Windows.Forms.TextBox txtComments;
    }
}