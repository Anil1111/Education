using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ReadOnly
{
    class Program
    {//readonly - поля только для чтения.

        //Поле только для чтения устанавливается толко конструктором или при создании как вот здесь.
        public readonly string field = "Hello";
        //конструктор
        public Program()
        {
            this.field = "Поле только для чтения";
            field += "!";
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.field);

            //Ошибка компиляции
            //program.field = "полю readonly нельзя присвоить значение напрямую";

            //Delay
            Console.ReadKey();
        }
    }
}
