using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_FileCreation
{
    //Создание/удаление файла
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем новый файл в корне диска D
            var file = new FileInfo(@"D:\Test.txt");
            //using (FileStream stream1 = file.Create())
            //{

            //}
            FileStream stream = file.Create(); //Когда мы создаем файл, нам автоматически возвращается ссылка 
            //на экземпляр класса FileStream, который и будет работать с этим файлом. Т.е одни механизмы создают файлы,
            //а другие с ними работают.
            //Т.е после создания файла, метод Create услужливо возвращает нам механизм, который нам позволит работать с этим файлом.

            //Выводим основную информацию о созданном файле.
            Console.WriteLine($"Full Name    : {file.FullName}");
            Console.WriteLine($"Attributes   : {file.Attributes.ToString()}");
            Console.WriteLine($"CreationTime : {file.CreationTime}");

            Console.WriteLine("Надмите любую клавишу для удаление файла");
            Console.ReadKey();

            //Закрываем FileStream
            stream.Close(); //попробовать закомментить эту строчку и когда программа выполняется - открыть файл вручную.
            //Будет ошибка т.к поток не закрыт. И когда будем удалять файл - то тоже бует ошибка если не закрыть поток
            //В ОС делается так: есть табица каталогов и если файл занят - то в значение атрибута ставится 1, если свободен - то 0.
            //ОС смотрит на этот флажок и решает что файл или занят или свободен. Если приложение вылетит, а программист
            //забудет сделать так, чтобы 1 изменился на 0, то OC будет думать, что файл используется приложением, хотя на самом деле это не так.

            //Удаляем файл
            file.Delete(); //т.е директории мы удаляем так: Directory.Delete(@"D:\TESTDIR\SUBDIR");, а файлы -через экземпляр класса FileInfo.

            Console.WriteLine("Файл успешно удален.");

            //Delay
            Console.ReadKey();

            //Thread - это нить - чм больше нитей, тем быстрее можно соткать полотно
            //Stream - это поток.
        }
    }
}
