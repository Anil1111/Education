using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_МАШИННАЯ_МАТЕМАТИКА_И_СИСТЕМЫ_СЧИСЛЕНИЯ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //byte a;
            MessageBox.Show("MinValue: 0, MaxValue: 255");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sbyte a;
            MessageBox.Show("MinValue:-128, MaxValue: 127");
        }                              

        private void button3_Click(object sender, EventArgs e)
        {
            //short b;
            MessageBox.Show("MinValue: -32768, MaxValue: 32767");
        }                            

        private void button4_Click(object sender, EventArgs e)
        {
            //ushort d;
            MessageBox.Show("MinValue: 0, MaxValue: 65535");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //int f;
            MessageBox.Show("MinValue: -2147483648, MaxValue: 2147483647");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //uint s;
            MessageBox.Show("MinValue: 0, MaxValue: 4294967295");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //long g;
            MessageBox.Show("MinValue: -9223372036854775809, MaxValue: 9223372036854775807");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //ulong h;
            MessageBox.Show("MinValue: 0, MaxValue: 18446744073709551615");
        }
    }
}
