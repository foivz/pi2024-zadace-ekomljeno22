using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox3.MouseEnter += pictureBox2_MouseEnter;
            pictureBox3.MouseLeave += pictureBox2_MouseLeave;
            pictureBox4.MouseEnter += pictureBox2_MouseEnter;
            pictureBox4.MouseLeave += pictureBox2_MouseLeave;

            label1.BorderStyle = BorderStyle.None;
            label2.BorderStyle = BorderStyle.None;
            label3.BorderStyle = BorderStyle.None;
            label4.BorderStyle = BorderStyle.None;
            label5.BorderStyle = BorderStyle.None;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Bottom;
            panel3.Dock = DockStyle.Top;
            panel2.Dock = DockStyle.Top;

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            panel2.BackColor = color;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            panel1.BackColor = color;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            panel4.BackColor = color;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            panel5.BackColor = color;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
