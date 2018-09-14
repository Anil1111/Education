using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Reflector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Можно выбрать либо exe, либо dll
        OpenFileDialog ofd = new OpenFileDialog();
        private Assembly assembly;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                string path = ofd.FileName;

                try
                {
                    assembly = Assembly.LoadFile(path);
                    textBox1.Text += "Сборка        " + path + "  -   Успешно загружена" + Environment.NewLine;

                }
                catch (FileNotFoundException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                //Вывод информации о всех типа в сборке
                textBox1.Text += "CПИСОК ВСЕХ ТИПОВ В СБОРКЕ:     " + assembly.FullName + Environment.NewLine;

                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    textBox1.Text += "Тип: "+type.Name + Environment.NewLine;
                    MethodInfo[] methodInfos = type.GetMethods();
                    foreach (MethodInfo methodInfo in methodInfos)
                    {
                        textBox1.Text += "Метод: " + methodInfo.Name + Environment.NewLine;
                    }

                    textBox1.Text += Environment.NewLine;
                }
            }
        }
    }
}
