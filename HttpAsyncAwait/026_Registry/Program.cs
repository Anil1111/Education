using System;
using Microsoft.Win32;

namespace _026_Registry
{
    class Program
    {
        //Реестр Windows - это служба операционной системы, которая отвечает за хранение разного вида настроек.
        //Чтобы открыть реестр - нужно в командной строке ввести regedit

        static void Main(string[] args)
        {
            //Совершаем навигацию в нужное место и открываем его для записи.
            RegistryKey myKey = Registry.CurrentUser; //очень удобно если за компом работают несколько юзеров и у каждого свои настройки
            RegistryKey writeKey = myKey.OpenSubKey("Software", true); //true означает, что мы открываем на запись!
            RegistryKey newKey = writeKey.CreateSubKey("TestFolder");

            //Совершаем запись в реестр
            newKey.SetValue("TheStringName", "I contain string value");
            newKey.SetValue("TheIn32Name", 1234567890);

            //Тут тип можно указать явно
            newKey.SetValue("AnotherName", 1234567890, RegistryValueKind.String);

            writeKey.Close();
            newKey.Close();

            //----------------------------------------------------
            //Совершаем навигацию по реестру и открываем ключ для чтения,
            //можно сразу указать ВЕСЬ ПУТЬ, а не совершать навигацию поэтапно.
            writeKey = myKey.OpenSubKey(@"Software\TestFolder");

            //Читаем данные и конвертируем их в нужный формат.
            string value1 = writeKey.GetValue("TheStringName") as string;
            int value2 = Convert.ToInt32(writeKey.GetValue("TheInt32Name"));
            int value3 = Int32.Parse(writeKey.GetValue("AnotherName") as string);

            writeKey.Close();

            //Покажем содержимое, чтобы убедится в том, что чтение прошло успешно.
            Console.WriteLine($"String: {value1}\nInt32: {value2}\nAnother: {value3}");

            //Delay
            Console.ReadKey();
        }
    }
}
