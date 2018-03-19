using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AdditionalTask
{
    public abstract class AbstractHandler
    {
        public AbstractHandler(string fileName)
        {
            this.filename = fileName;
        }

        public void Create()
        {
            Console.WriteLine($"Файл с именем {this.filename} создан");
        }
        public abstract void Open();
        public abstract void Change();
        public abstract void Save();
        protected string filename;
    }
}
