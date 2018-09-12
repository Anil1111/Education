using System;
using Microsoft.Win32;

namespace _006_Registry_OpenSubKey
{
    class Program
    {
        static void Main(string[] args)
        {
            //Совершаем навигацию по реестру и открываем ключ для чтения,
            //можно сразу указать весь путь, а не совершать навигацию поэтапно.
            RegistryKey key = Registry.CurrentUser;
            RegistryKey subKey = key.OpenSubKey(@"Software\TestFolder");

            //Читаем данные и конвертируем их в нужный формат.
            string value1 = subKey.GetValue("TheStringName") as string;
            int value2 = Convert.ToInt32(subKey.GetValue("TheInt32Name"));
            int value3 = Int32.Parse(subKey.GetValue("AnotherName") as string);

            subKey.Close();

            //Покажем содержимое, чтобы убедится в том, что чтение прошло успешно.
            Console.WriteLine($"String: {value1}\nInt32: {value2}\nAnother: {value3}");

            //Delay
            Console.ReadKey();
        }
    }
}
