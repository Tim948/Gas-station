using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 b;
        private void button1_Click(object sender, EventArgs e)
        {
            b = new Form2();
            b.Visible = true;
        }
        private Form4 a;
        private void button2_Click(object sender, EventArgs e)
        {
            a = new Form4();
            a.Visible = true;
        }
        private Form6 c;
        private void button3_Click(object sender, EventArgs e)
        {
            c = new Form6();
            c.Visible = true;

        }
        private Form8 d;
        private void button4_Click(object sender, EventArgs e)
        {
            d = new Form8();
            d.Visible = true;
        }
        private Form10 f;
        private void button5_Click(object sender, EventArgs e)
        {
            f = new Form10();
            f.Visible = true;
        }
        private Form11 g;
        private void button6_Click(object sender, EventArgs e)
        {
            g = new Form11();
            g.Visible = true;
        }
    } 
}
