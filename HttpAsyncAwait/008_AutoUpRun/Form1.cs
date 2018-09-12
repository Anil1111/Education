using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _008_AutoUpRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
             * Реестр 64-разрядных версий Windows подразделяется на 32- и 64-разрядные разделы.
             * Большинство 32-разрядных разделов имеют те же имена, что и их аналоги в 64-разрядном разделе, и наоборот.
             * По умолчанию редактор реестра 64-разрядных версий Windows отображает 32-разрядные разделы в разделе HKEY_LOCAL_MACHINE\Software\WOW6432Node
             */

            //RegistryKey - Инициализация объекта для работы с веткой LocalMachine
            RegistryKey key = null;
            RegistryKey subKey = null;
            try
            {
                key = Registry.LocalMachine;
                subKey = key.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
                string temp = (string)subKey.GetValue("TestItemStart", "programm is NOT set to auto upload");

                if (temp != "programm is NOT set to auto upload")
                {
                    label1.Text = "Программа стоит в автозагрузке";
                }
            }
            catch (Exception e)
            {
                label1.Text = "Программа НЕ стоит в автозагрузке";
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                key.Close();
                subKey.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Установка программы в автозагрузку
        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey key = null;
            RegistryKey subKey = null;
            try
            {
                key = Registry.LocalMachine;
                subKey = key.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                //Путь к данному приложению
                subKey.SetValue("TestItemStart", Application.StartupPath + @"\008_AutoUpRun.exe");


                label1.Text = "Программа стоит в автозагрузке";
            }
            catch (Exception exception)
            {
                label1.Text = "Программа НЕ стоит в автозагрузке";
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                key.Close();
                subKey.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey key = null;
            RegistryKey subKey = null;
            try
            {
                key = Registry.LocalMachine;
                subKey = key.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                //Путь к данному приложению
                subKey.DeleteValue("TestItemStart");

                label1.Text = "Программа НЕ стоит в автозагрузке";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                key.Close();
                subKey.Close();
            }
        }
    }
}
