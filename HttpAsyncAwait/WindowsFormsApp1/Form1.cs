using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//Comparison with true is redundant - по этому я и убрал radioButton3.Checked == true
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text));
            if (radioButton2.Checked )
                textBox3.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            if (radioButton3.Checked)
                textBox3.Text = Convert.ToString(String.Concat(textBox1.Text, textBox2.Text));
            if (radioButton4.Checked)
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
        }
    }
}
