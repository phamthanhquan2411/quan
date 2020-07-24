using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinhtiendien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string a, h;
        public string b;
        public string c;
        public string d;
        public string g;
        public string f;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label7.Text = a;
            label8.Text = b;
            label9.Text = c;
            label10.Text = d;
            label11.Text = g;
            label12.Text = f;
            label13.Text = h;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
