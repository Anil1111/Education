using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _019_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            //Через FileInfo мы НЕ РАБОТАЕМ с файлом на запись или на чтение.
            //С файлом мы работаем через Стримы(FileStream, StreamWriter, StreamReader).                       //что другие программы могут делать пока мы с этим файлом работаем
            //FileStream сам по себе умеет работать ТОЛЬКО С БАЙТАМИ
            FileStream fileStream = new FileStream(@"D:\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //StreamWriter позволяет писать в файл ТЕКСТ БЕЗ ИЗВРАЩЕНИЙ.
            //Есть просто FileStream, а есть Stream`ы - декораторы, которые 
            //ОБВОРИЧИВАЮТ обычный FileStream и придают ему новые свойства, напрмер StreamWriter и StreamReader
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Hello");
            //изменения сразу же не пишутся в файл, а накапливаются в буффере и пишутся в файл уже большими порциями
            streamWriter.Flush(); //для того, чтобы "слить изменения в файл" - мы вызываем метод Flush

            fileStream.Position = 0;

            StreamReader streamReader = new StreamReader(fileStream);
            Console.WriteLine(streamReader.ReadLine());

            streamReader.Close(); //закроет и fileStream

            // -------------------------------------------------------------------------------------------------
            //Потоков очень много! Они все наследуются от базового класса Stream


            MemoryStream memoryStream = new MemoryStream(); //поток в оперативной памяти
            //NetworkStream networkStream = new NetworkStream(new Socket(SocketType.Stream, ProtocolType.Udp)); //сетевой поток, который хранится удалнно на сервере.
            //UnmanagedMemoryStream unmanagedMemoryStream = new UnmanagedMemoryStream(); //хранение информации на куче Windows.


            //Классы - декораторы
            StringReader stringReader = new StringReader("Hello"); //Позволяет читать строку как поток - т.е строка выступает ядром и источником информации.
            StringWriter stringWriter = new StringWriter(); //работает подробно StreamBuilder`у

            //BufferedStream имеет возможность накапливать информацию в предопределенном буфере и потом, с вызовом метода Flush
            //или с переполнение буфера ИНФОРМАЦИЯ БУДЕТ СЛИВАТЬСЯ В тот Stream, который "лежит под ним" - в данном случае - memoryStream
            BufferedStream bufferedStream = new BufferedStream(memoryStream);

            //BinaryReader и BinaryWriter умеют читать и писать символы, строки, числа В БИНАРНЫЙ ПОТОК,
            //чтобы не менять кодировку. Бинарный серилизатор - самый БЫСТРЫЙ серилизатор, который только есть!
            BinaryReader binaryReader = new BinaryReader(memoryStream); 
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

        }
    }
}
