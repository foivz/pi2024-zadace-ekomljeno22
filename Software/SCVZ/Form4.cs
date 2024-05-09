using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox3.MouseEnter += pictureBox2_MouseEnter;
            pictureBox3.MouseLeave += pictureBox2_MouseLeave;
            pictureBox4.MouseEnter += pictureBox2_MouseEnter;
            pictureBox4.MouseLeave += pictureBox2_MouseLeave;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            panel2.BackColor = color;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            panel1.BackColor = color;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Bottom;
            panel3.Dock = DockStyle.Top;
            panel2.Dock = DockStyle.Top;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#B9B9B9");
            panel2.BackColor = color;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
