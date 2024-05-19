namespace SCVZ
{
    partial class FrmAddElement
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
            this.lblAddElement = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnAddMenus = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnAddMoreMeals = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddElement
            // 
            this.lblAddElement.AutoSize = true;
            this.lblAddElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddElement.ForeColor = System.Drawing.Color.White;
            this.lblAddElement.Location = new System.Drawing.Point(193, 25);
            this.lblAddElement.Name = "lblAddElement";
            this.lblAddElement.Size = new System.Drawing.Size(117, 36);
            this.lblAddElement.TabIndex = 0;
            this.lblAddElement.Text = "Dodaj...";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 41);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Controls.Add(this.lblAddElement);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(512, 80);
            this.pnlNav.TabIndex = 21;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeal.Location = new System.Drawing.Point(15, 114);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(479, 41);
            this.btnAddMeal.TabIndex = 23;
            this.btnAddMeal.Text = "Jelo";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnAddMenus
            // 
            this.btnAddMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMenus.Location = new System.Drawing.Point(15, 177);
            this.btnAddMenus.Name = "btnAddMenus";
            this.btnAddMenus.Size = new System.Drawing.Size(479, 41);
            this.btnAddMenus.TabIndex = 24;
            this.btnAddMenus.Text = "Meni";
            this.btnAddMenus.UseVisualStyleBackColor = true;
            this.btnAddMenus.Click += new System.EventHandler(this.btnAddMenus_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(15, 241);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(479, 41);
            this.btnAddStaff.TabIndex = 25;
            this.btnAddStaff.Text = "Osoblje";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnAddMoreMeals
            // 
            this.btnAddMoreMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoreMeals.Location = new System.Drawing.Point(15, 367);
            this.btnAddMoreMeals.Name = "btnAddMoreMeals";
            this.btnAddMoreMeals.Size = new System.Drawing.Size(479, 41);
            this.btnAddMoreMeals.TabIndex = 26;
            this.btnAddMoreMeals.Text = "Više jela";
            this.btnAddMoreMeals.UseVisualStyleBackColor = true;
            this.btnAddMoreMeals.Click += new System.EventHandler(this.btnAddMoreMeals_Click);
            // 
            // FrmAddElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.btnAddMoreMeals);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnAddMenus);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlNav);
            this.Name = "FrmAddElement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddElement";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddElement;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnAddMenus;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnAddMoreMeals;
    }
}