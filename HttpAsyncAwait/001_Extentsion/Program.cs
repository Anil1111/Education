using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Рaсширяющик методы (Extension methods) - реализует идею динамического наследования.
//Расширяющие методы могут быть тол ко СТАТИЧЕСКИМИ и создаваться в статических классах.
// Даже не смотря на то, что статические методы могут быть не в статических классах,
// если статических метод ЯВЛЯЕТСЯ РАСШИРЯЕМЫМ - то он может быть ТОЛЬКО в СТАТИЧЕСКОМ КЛАССЕ
//Методы не расширяются, а расширяют другие типы!
namespace _001_Extentsion
{
    static class ExtentionClass
    {
        //this - сообщает компилятору, что данный метод является расширяющим (Extension)!
        public static void ExtensionMethod(this string value) //this string value - это АРГУМЕНТ РАСШИРЕНИЯ.
        {
            Console.WriteLine(value);
        }
        // Слово this:    1. ссылка на себя  this.field
        //                2. конструктор  public Point(string name)
        //                                    : this(300, 450)
        //                3. индексатор    public int this[int index]
        //                4. расширяющие методы  public static void ExtensionMethod(this string value)
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Текстовая строка";

            //Вызов метода, как статического
            ExtentionClass.ExtensionMethod(text);

            //ВЫЗОВ МЕТОДА КАК РАСШИРЯЮЩЕГО!!
            text.ExtensionMethod();

            //Delay
            Console.ReadKey();
        }
    }
}
