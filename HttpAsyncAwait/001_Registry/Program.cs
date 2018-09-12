using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _001_Registry
{
    class Program
    {
        //Структура реестра
        static void Main(string[] args)
        {
            // Registry - это класс, предоставляющий эксклюзивный доступ к ключам реестра для простых операций
            // RegistryKey - класс реализует методы для просмотра дочерних ключей, создания новых или чтения
            //               включая установку уровня безопасности для них.

            RegistryKey[] keys = new RegistryKey[]
            {
                   Registry.ClassesRoot,
                   Registry.CurrentUser,
                   Registry .LocalMachine,
                   Registry.Users,
                   Registry.CurrentConfig,
                   Registry.PerformanceData,
                   //Registry.DynData - устарел
            };

            foreach (var key in keys)
            {
                Console.WriteLine($"{key.Name} - имеет всего элементов: {key.SubKeyCount}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
