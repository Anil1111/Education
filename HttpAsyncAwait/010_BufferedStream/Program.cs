using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_BufferedStream
{
    //Буффер - это блок байтов памяти, который используется для кеширования данных,
    //тем самым уменьшая количество обращеий к операционной системе.
    //Таки образом, буферизация повышает скорость чтения и записи.

    //Методы Read и Write класса BufferedStream обслуживают буфер автоматически.
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = File.Create(@"D:\test.txt");
            BufferedStream buffered = new BufferedStream(file);

            StreamWriter writer  = new StreamWriter(buffered);
            
            writer.WriteLine("Some data...");

            buffered.Position = 0;

            //При сбросе буфера buffered, данные из него попадают в связанный поток - file.
            writer.Close();

            //Delay
            Console.ReadKey();
        }
    }
}
