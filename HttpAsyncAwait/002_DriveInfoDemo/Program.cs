using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_DriveInfoDemo
{
    //Получание информации о дисках
    class Program
    {
        static void Main(string[] args)
        {
            //Создание коллекции дисков.
            DriveInfo[] drivers = DriveInfo.GetDrives();

            //Вывод информации о дисках компьютра.
            foreach (var drive in drivers)
            {
                Console.WriteLine($"Driver: {drive.Name} Type: {drive.DriveType}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
