using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ");
            var key = Console.ReadLine();
            DocumentWorker doc = null;
            //Нам удобно поставить условие, и взависимости от этого условия создавать экземпляры определенных классов,
            //которые все равно потом будут приводится к  DocumentWorker(я же не зря выше написал), но методы , которые мы
            //уже за"override"ли, никуда не делись и будут выводится даже если я сделаю upcast т.к 
            //1Я ФОРМА ПРИНУДИТЕЛЬНОГО(КЛАССИЧЕСКОГО) ПОЛИМОРФИЗМА -OVERRIDE СИЛЬНЕЕ ЧЕМ 2Я - ПРИВОДЕНИЕ ТИПОВ.
            switch (key)
            {
                case "pro":
                    doc = new ProDocumentWorker(); //upcast , но переопределенные методы никуда не делись, выведется то, что и должно
                                                   //в соответствии с классом ProDocumentWorker
                    break;
                case "expert":
                    doc = new ExpertDocumentWorker();//upcast - точно то же самое.
                    break;
                default:
                    {
                        Console.WriteLine("Ключ неверен");
                        doc = new DocumentWorker();
                        break;
                    }
            }
            
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            //Delay
            Console.ReadKey();
        }
    }
}
