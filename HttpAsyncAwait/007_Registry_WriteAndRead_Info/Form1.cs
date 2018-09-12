using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _007_Registry_WriteAndRead_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            RegistryKey registryKey = null;
            RegistryKey subKey = null;
            try
            {
                //Инициализируем объект Registry для работы с веткой реестра CurrentUser
                registryKey = Registry.CurrentUser;

                //CreateSubKey - создать по указанному пути ключ
                subKey = registryKey.CreateSubKey(@"Software\TestFolder\Test1");

                //Запись значений в реестр
                subKey.SetValue("CurrentText", textBox1.Text); //если такое свойство уже есть - ОНО ПЕРЕЗАПИШЕТСЯ!

                MessageBox.Show($"Запись {textBox1.Text} создана в реестре");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                registryKey?.Close();
                subKey?.Close();
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            RegistryKey registryKey = null;
            RegistryKey subKey = null;
            try
            {
                //Инициализируем объект Registry для работы с веткой реестра CurrentUser
                registryKey = Registry.CurrentUser;

                //Идем к ключу и читаем данные с него
                subKey = registryKey.OpenSubKey(@"Software\TestFolder\Test1");
                string value = subKey.GetValue("CurrentText") as string;

                //Помещаем данные в тексбок
                textBox2.Text = value;
                MessageBox.Show("Чтение выполнено!");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                registryKey?.Close();
                subKey?.Close();
            }
        }
    }
}
