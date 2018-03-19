using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AdditionalTask
{
    //public class DocumentWorker
    //{
    //    public void OpenDocument()
    //    {
    //        Console.WriteLine("Документ открыт");
    //    }

    //    public virtual void EditDocument()
    //    {
    //        Console.WriteLine("Редоактирование документа доступно в версии Про");
    //    }

    //    public virtual void SaveDocument()
    //    {
    //        Console.WriteLine("Сохранение документа доступно в версии Про");
    //    }
    //}

    //public class ProDocumentWorker:DocumentWorker
    //{
    //    public override void EditDocument()
    //    {
    //        Console.WriteLine("Документ отредактирован");
    //    }

    //    public override void SaveDocument()
    //    {
    //        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматаъ доступно в версии Эксперт");
    //    }
    //}

    //public class ExpertDocumentWorker : ProDocumentWorker
    //{
    //    public override void SaveDocument()
    //    {
    //        Console.WriteLine("Документ сохранен в новом формате");
    //    }
    //}
    public class XmlHandler : AbstractHandler
    {
        public XmlHandler(string fileName)
            :base(fileName)
        {    
        }

        public override void Open()
        {
            Console.WriteLine($"Вы открыли XML файл с именем {this.filename}");
        }

        public override void Change()
        {
            Console.WriteLine($"Вы изменили XML файл с именем {this.filename}");
        }

        public override void Save()
        {
            Console.WriteLine($"Вы сохранили XML файл с именем {this.filename}");
        }
    }

    public class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Open()
        {
            Console.WriteLine($"Вы открыли TXT файл с именем {this.filename}");
        }

        public override void Change()
        {
            Console.WriteLine($"Вы изменили TXT файл с именем {this.filename}");
        }

        public override void Save()
        {
            Console.WriteLine($"Вы сохранили TXT файл с именем {this.filename}");
        }
    }

    public class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Open()
        {
            Console.WriteLine($"Вы открыли DOC файл с именем {this.filename}");
        }

        public override void Change()
        {
            Console.WriteLine($"Вы изменили DOC файл с именем {this.filename}");
        }

        public override void Save()
        {
            Console.WriteLine($"Вы сохранили DOC файл с именем {this.filename}");
        }
    }
}
