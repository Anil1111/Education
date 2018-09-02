using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_FileSystemWatcher
{
    //Отслеживание изменений в системе.
    class Program
    {
        static void Main(string[] args)
        {
            //Запустить программу, добавить и удалить новый файл.
            //Создание наблюдателя и концентрация его внимания на системном диске.
            var watcher = new FileSystemWatcher {Path = @"D:\"};

            //Зарегестрировать обработчики событий.
            watcher.Created += new  FileSystemEventHandler(WatcherChanged);  //тип делегата указывать на обязательно т.к оно есть в событии
            watcher.Deleted += WatcherChanged;
            watcher.Renamed += new RenamedEventHandler(WatcherChanged);
            watcher.Changed += WatcherChanged;

            //При наблюдении за файловой системой число изменений может превысить вохможности FileSystemWacher.
            //Когда происходит слишком много событий, FileSystemWacher генерирует событие Error
            watcher.Error += new ErrorEventHandler(WatcherError);

            //Начать мониторинг
            watcher.EnableRaisingEvents = true;

            //Delay
            var change = watcher.WaitForChanged(WatcherChangeTypes.All);
            Console.WriteLine(change.ChangeType);

            Console.ReadKey();
        }

        //Обработчик события
        static void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Directory changed({e.ChangeType}): {e.FullPath}");  // Created, Deleted, Changed, Renamed, All
        }

        static void WatcherError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.GetException());
        }
    }
}
