using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Methods
{          
    class Program
    { //Методы (Функции)
        //На 15-й строке создаем метод с именем Function, который принимает один строковой
        //аргумент и возвращает строковое значение.
        //В теле метода строковой локальной переменной sentance присваиваем конкатенацию строк и агрумента,
        // используя ключевое слово return, возвращаем значение переменной sentance.
        static string Function (string name)
        {
            string sentence = "Hello" + name;
            return sentence;
        }
        static void Main(string[] args)
        {
            //В теле метода Main на 25-й строке, создаем строковую локлаьную переменную с именем sentance,
            //присваиваем ай возвращаемое значение метода Function, которому в качестве параметра передаем строку - "Roman".
            string sentence = Function("Roman");
            Console.WriteLine(sentence);

            //Delay
            Console.ReadKey();
        }
    }
}
