using System;
using Microsoft.Win32;

namespace _001_Registry_navigation
{
    class Program
    {
        //Навигация по реестру
        static void Main(string[] args)
        {
            // Процесс получения ссылки на объект RegistryKey называется ОТКРЫТИЕМ КЛЮЧА.
            RegistryKey myKey = Registry.LocalMachine;
            RegistryKey software = myKey.OpenSubKey("Software");
            RegistryKey microsoft = software.OpenSubKey("Microsoft");

            Console.WriteLine($"{microsoft?.Name} - имеет {microsoft?.SubKeyCount} элементов");

            software.Close();
            microsoft.Close();

            //Попытка открыть НЕСУЩЕСТВУЮЩИЙ КЛЮЧ. Переменной software будет присвоено значение NULL.
            software = myKey.OpenSubKey("NonExistName", RegistryKeyPermissionCheck.Default);

            try
            {
                //Попытка обратится к переменной, значение которой не присвоено
                Console.WriteLine($"Открыли узел: {software.Name}"); //NullReferanceExeption не будет если поставить ЭЛВИС ОПЕРАТОР: software?.Name
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}\n{e.GetType()}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
