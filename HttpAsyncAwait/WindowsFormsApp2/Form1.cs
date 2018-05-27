using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //EventArgs e - содержит вспомагательные данные о событии,
        //в данном случае, была ли нажата кнопка мышью (MouseEventArgs) или клавиатурой (EventArgs).
        //object sender - источник события.

        private void button_Click(object sender, EventArgs e) //EventArgs - вспомагательный класс, который несет в себе доп.информацию для события.
        {
            MessageBox.Show($"Нажата кнопка: {sender.ToString()}", $"Чем нажали: {e.ToString()}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
