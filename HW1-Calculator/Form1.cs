using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_Calculator
{
    public partial class Form1 : Form
    {
        private bool idle = true;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (idle)
                textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
            idle = false;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
           var res = cal(textBox1.Text);
            textBox1.Text += " = " + res.ToString();
            idle= true;
        }

        private object cal(string text)
        {
            DataTable dt = new DataTable();
            var v = new object();
            try
            {
                v = dt.Compute(text, "");
            }
            catch (Exception ex)
            {
                v = "NaN";
            }
            return v;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1 .Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
