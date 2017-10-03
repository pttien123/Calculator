using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcong_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt16(textBox1.Text);
            double b = Convert.ToInt16(textBox1.Text);
            double c = a + b;
            textBox3.Text = c.ToString();
        }

        private void bttru_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt16(textBox1.Text);
            double b = Convert.ToInt16(textBox1.Text);
            double c = a + b;
            textBox3.Text = c.ToString();
        }
    }
}
