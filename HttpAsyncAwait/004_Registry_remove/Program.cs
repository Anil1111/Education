using System;
using Microsoft.Win32;

namespace _004_Registry_remove
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey myKey = Registry.CurrentUser;

            //Для удаления тоже нужно иметь права редактирования
            RegistryKey writeKey = myKey.OpenSubKey("Software", true);

            //Вывод на экран всего содержимого ключа поименно.
            string[] keyNames = writeKey.GetSubKeyNames();
            foreach (var name in keyNames)
            {
                if (name == "TestFolder")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string(' ', 5) + name);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.WriteLine(new string(' ', 5) + name);
                }
            }

            //Теперь пытаемся удалить ключ!
            try
            {
                Console.WriteLine($"Всего записей в {writeKey.Name}: {writeKey.SubKeyCount}");
                writeKey.DeleteSubKey("TestFolder");

                Console.WriteLine(@"Запись 'TestFolder' была успешно удалена.");
                Console.WriteLine($"Теперь записей стало: {writeKey.SubKeyCount}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                writeKey.Close();
            }

            //Delay
            Console.ReadKey();

        }
    }
}
