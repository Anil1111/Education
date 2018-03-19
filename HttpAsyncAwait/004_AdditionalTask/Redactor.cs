using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AdditionalTask
{
    class Redactor
    {
        public AbstractHandler ChooseDocument()
        {
            Console.WriteLine("Введите имя файла");
            var fileName = Console.ReadLine();
            AbstractHandler file = null;
            for (int i = 0; i < 10 && file == null; i++)
            {
                Console.WriteLine("Введите  файл с форматом, например file.xml, file.txt или file.doc");
                string nameAndFormat = Console.ReadLine();
                string format = nameAndFormat.Substring(nameAndFormat.Length - 4); //в скобках указана позиция с которого будет браться substring!
                                                                                   //-4 потому, что .txt/.doc/.xml - это 4 знака.
                switch (format.ToLower())
                {
                    case ".xml":
                        file = new XmlHandler(fileName);
                        break;
                    case ".txt":
                        file = new TXTHandler(fileName);
                        break;
                    case ".doc":
                        file = new DOCHandler(fileName);
                        break;
                    default:
                        Console.WriteLine("Вы ввели неправильное имя файла");
                        break;
                }
            }

            return file;
        }
    }
}
