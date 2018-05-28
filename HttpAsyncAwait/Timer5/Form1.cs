using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private EventHandler start;
        private EventHandler stop;
        private EventHandler reset;

        public event EventHandler Start
        {
            add { start += value; }
            remove { start -= value; }
        }

        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }

        public event EventHandler Reset
        {
            add { reset += value; }
            remove { reset -= value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start.Invoke(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop.Invoke(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset.Invoke(sender, e);
        }

    }
}
