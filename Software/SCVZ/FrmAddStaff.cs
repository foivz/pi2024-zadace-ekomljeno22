﻿using SCVZ.Models;
using SCVZ.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class FrmAddStaff : Form
    {
        public FrmAddStaff()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
        }
    }
}
