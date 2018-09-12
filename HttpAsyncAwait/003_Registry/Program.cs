using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _003_Registry
{
    class Program
    {
        //Сначала сделали app.manifest - файлик где хранятся конфиги и я там могу сделать чтобы мое приложение запускалось с правами администратора
        static void Main(string[] args)
        {
            RegistryKey myKey = Registry.CurrentUser;

            //Второй аргумент (true) говорит о том, что я собираюсь записывать
            RegistryKey writeKey = myKey.OpenSubKey("Software", true);

            try
            {
                Console.WriteLine($"Всего записей в {writeKey.Name}: {writeKey.SubKeyCount}");

                //Попытка создать новый ключ(записать!).
                RegistryKey newKey = writeKey.CreateSubKey("TestFolder");
                //Запись прошла успешно в HKEY_CURRENT)USER\Software\...

                Console.WriteLine($@"Запись '{newKey.Name}' успешно внесена в реестр", newKey.Name);
                Console.WriteLine($"Теперь записей стало: {writeKey.SubKeyCount}");

            }
            catch (Exception e)
            {
                //Если возникает проблема - выводим сообщение на экран.
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Закрыть ключ нужно обязательно
                myKey.Close();
            }

            //Delay
            Console.ReadKey();
        }
    }
}
