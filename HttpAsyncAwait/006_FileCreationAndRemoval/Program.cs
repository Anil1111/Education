using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_FileCreationAndRemoval
{
    // Создание/открытие(с помощью метода Open)/удаление файла
    class Program
    {
        static void Main(string[] args)
        {
            //Cоздаем новый фал в коревом каталоге диска D:
            var file = new FileInfo(@"D:\Test.txt");

            //FileMode.OpenOrCreate - ЕСЛИ: существует ТО: открыть ИНАЧЕ: создать нвый
            //FileAccess.Read - только для чтения.
            //FileShare.None - Совместный доступ(т.е открыть файл в друх разных программах) - Нет.

            //ВТОРОЙ СПОСОБ СОЗДАТЬ ФАЙЛ! Вызываем метод Open
            FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            //Выводим основную информацию о файле - там ещё МНОГО ДРУГИХ СВОЙСТВ
            Console.WriteLine($"Full Name      : {file.FullName}");
            Console.WriteLine($"Attribute      : {file.Attributes.ToString()}");
            Console.WriteLine($"Creation time  : {file.CreationTime}");

            Console.WriteLine("Нажмите любую клавишу для удаления файла.");
            Console.ReadKey();

            //Закрываем FileStream
            //это очень хорошо, что мы не можем использовать один и тот же файл одновременно несколькими программами.
            //например это бы привело к "режиму гонки", когда программы соревнутся кто первый запишет в файл и это бы
            //привело к использовани неактуальных данных и т.д
            stream.Close();

            //Удаляем файл
            file.Delete();

            Console.WriteLine("Файл успешно удален.");

            //Delay
            Console.ReadKey();
        }
    }
}
